
curr.loc <- paste(getSrcDirectory(function(x) {x}),"RPackages",sep="")
library("FactoMineR",lib.loc=curr.loc)
library("factoextra",lib.loc=curr.loc)
library("gplots",lib.loc=curr.loc)
library("corrplot", lib.loc = curr.loc)
library("ggpubr", lib.loc = curr.loc)
library(utils,lib.loc=curr.loc)

options(warn = -1)


file.path <- getSrcDirectory(function(x) {x})
charts.dir <- paste(file.path, "plots/", sep = "")

print("Extract external data into contingency table")

dataset.file.name <- "delinquents_take_5a.txt"
print(paste("Source file ", dataset.file.name, " analyzed on ", Sys.time(), sep = ""))

#data.file.path <- paste(file.path,"datasets/students.txt",sep="")
#data.file.path <- paste(file.path,"datasets/housetasks.txt",sep="")
data.file.path <- paste(file.path,"datasets/",dataset.file.name,sep="")
ht.data <- read.delim(data.file.path)
#ht.data <- read.delim(data.file.path, header=TRUE, sep=",")
ht.data <- read.delim(data.file.path, header=TRUE, row.names=1,sep=",")
dt <- as.table(as.matrix(ht.data))

chart.filepaths <- c()


tryCatch({
  filepath1 <- paste(charts.dir,"ca_balloonplot",".png",sep="")
  png(filename=filepath1,width = 650, height = 480, units = "px")
  print(balloonplot( t( dt), main ="students.data", xlab ="", ylab ="", label = FALSE, show.margins = FALSE,colmar=3))
},warning = function(w) {
  print(w)
},error = function(e) {
  print(e)
},finally = {
  if (dev.cur()>1)
    dev.off()
})
# balloonplot( t( dt), main =" housetasks", xlab ="", ylab ="", label = FALSE, show.margins = FALSE)
chart.filepaths <- c(chart.filepaths,paste("baloon_plot",filepath1,sep=","))

cat("\n")
print(ht.data)

chisq <- chisq.test(ht.data)

cat(c("CHI-SQUARE TEST:",paste("statistics=",chisq$statistic,",p.value=",chisq$p.value,",method=",chisq$method,sep="")))

if(is.nan(chisq$statistic)){
  cat(paste("Result: Unablee to perform data dependency test.\n",sep=""))
} else if(chisq$statistic > 200){
  cat(paste("Result: chi square is high (",chisq$statistic,") which means high dependency between columns (variables) and rows (individuals or observations)\n",sep=""))
} else if((50 < chisq$statistic) && (chisq$statistic<=201)){
  cat(paste("Result: chi square is medium (",chisq$statistic,") which means medium dependency between columns (variables) and rows (individuals or observations)\n",sep=""))
} else {
  cat(paste("Result: chi square is low (",chisq$statistic,") which means low dependency between columns (variables) and rows (individuals or observations)\n",sep=""))
}

cat("\n\n")

res.ca <- NULL
res.ca <- CA(ht.data,graph=FALSE)
eig.val <- get_eigenvalue(res.ca)
print("List of Dimensions (aka Eigenvalues)")
print(eig.val)
cat("\n\n")

tryCatch({
  filepath2 <- paste(charts.dir,"ca_screeplot",".png",sep="")
  #png(filename=filepath1)
  png(filename=filepath2)
  print(fviz_screeplot(res.ca,addlabels=TRUE,ylim = c(0,50)) )
},warning = function(w) {
  print(w)
},error = function(e) {
  print(e)
},finally = {
  if (dev.cur()>1)
    dev.off()
})
chart.filepaths <- c(chart.filepaths,paste("scree_plot",filepath2,sep=","))


# Our data contains 13 rows and 4 columns. 
# If the data were random, the expected value of the eigenvalue for each axis would be 
exp.eig.val.row <- 1/( nrow( ht.data)-1) 
cat(paste("If the data were random, the expected value of the eigenvalue for each row would be ",exp.eig.val.row,"\n",sep=""))
# Likewise, the average axis should account for 1/( ncol( housetasks)-1) = 1/ 3 = 33.33% in terms of the 4 columns.
exp.eig.val.col <- 1/( ncol( ht.data)-1) 
cat(paste("Likewise, the average eigenvalue accounted for each column would be ",exp.eig.val.col,"\n",sep=""))
cat("\n\n")

# Any axis with a contribution larger than the maximum of these two percentages should be considered as important 
# and included in the solution for the interpretation of the data.
exp.max <- 100*max(exp.eig.val.row, exp.eig.val.col) 

tryCatch({
  filepath3 <- paste(charts.dir,"ca_screeplot_avgline",".png",sep="")
  #png(filename=filepath1)
  png(filename=filepath3)
  print(fviz_screeplot(res.ca) + geom_hline(yintercept = exp.max, linetype = 2, color = "red")
        + labs(title="View of Reduced Dimensions Space with each Component Contribution"))
},warning = function(w) {
  print(w)
},error = function(e) {
  print(e)
},finally = {
  if (dev.cur()>1)
    dev.off()
})
chart.filepaths <- c(chart.filepaths,paste("scree_plot_avgline",filepath3,sep=","))

tryCatch({
  filepath4 <- paste(charts.dir,"ca_symmetric_biplot",".png",sep="")
  png(filename=filepath4)
  # repel = TRUE to avoid text overlapping
  print(fviz_ca_biplot(res.ca, repel = TRUE)
        + labs(title = "View of Observations and Variables Representation in Reduced Dimensions Space"))
},warning = function(w) {
  print(w)
},error = function(e) {
  print(e)
},finally = {
  if (dev.cur()>1)
    dev.off()
})
chart.filepaths <- c(chart.filepaths,paste("ca_symmetric_biplot",filepath4,sep=","))

##### START - GRAPHIC ANALYSIS OF ROW OBSERVATIONS ##################################################################

row.ca <- get_ca_row(res.ca)
# row.ca
# 
print("Parameters in the new (Orthogonal, uncorrelated) space")
print("Top Rows Coordinates")
head(row.ca$coord)
cat("\n\n")
print("Top Rows Squared Correlations")
head(row.ca$cos2)
cat("\n\n")
print("Top Rows Contributions")
head(row.ca$contrib)
cat("\n\n")
print("Top Rows Data Inertia (or Variance)")
head(row.ca$inertia)
cat("\n\n")
# fviz_ca_row(res.ca, repel=TRUE)

# Color by cos2 values: quality on the factor map 
tryCatch({
  filepath5 <- paste(charts.dir,"ca_rows_cos2_plot",".png",sep="")
  png(filename=filepath5)
  print(fviz_ca_row( res.ca, col.row = "cos2",gradient.cols = c("#00AFBB", "#E7B800", "#FC4E07"), repel = TRUE))
},warning = function(w) {
  print(w)
},error = function(e) {
  print(e)
},finally = {
  if (dev.cur()>1)
    dev.off()
})
chart.filepaths <- c(chart.filepaths,paste("ca_rows_cos2_plot",filepath5,sep=","))

print("Rows Quality of Representation (Cos2) in Each Dimension")
tryCatch({
  filepath6 <- paste(charts.dir,"ca_rows_cos2_matrix",".png",sep="")
  png(filename=filepath6)
  print(corrplot(row.ca$cos2, is.corr = FALSE)
        +labs(title="Matricial View: Quality of Representation of Observations and Variables in Reduced Dimensions Space"))
},warning = function(w) {
  print(w)
},error = function(e) {
  print(e)
},finally = {
  if (dev.cur()>1)
    dev.off()
})
chart.filepaths <- c(chart.filepaths,paste("ca_rows_cos2_matrix",filepath6,sep=","))
cat("\n\n")

# Cos2 of rows on Dim. 1 and Dim. 2 
tryCatch({
  filepath7 <- paste(charts.dir,"ca_rows_cos2_bar",".png",sep="")
  png(filename=filepath7)
  print(fviz_cos2( res.ca, choice = "row", axes = 1: 2))
},warning = function(w) {
  print(w)
},error = function(e) {
  print(e)
},finally = {
  if (dev.cur()>1)
    dev.off()
})
chart.filepaths <- c(chart.filepaths,paste("ca_rows_cos2_bar",filepath7,sep=","))

print("Rows Contributions to Each Dimension")
tryCatch({
  filepath8 <- paste(charts.dir,"ca_rows_contrib_matrix",".png",sep="")
  png(filename=filepath8)
  print(corrplot(row.ca$contrib,is.corr=FALSE))
},warning = function(w) {
  print(w)
},error = function(e) {
  print(e)
},finally = {
  if (dev.cur()>1)
    dev.off()
})
chart.filepaths <- c(chart.filepaths,paste("ca_rows_contrib_matrix",filepath8,sep=","))
cat("\n\n")

# rows contributions to Dim1 and Dim2 respectively
tryCatch({
  filepath9 <- paste(charts.dir,"ca_rows_contrib_dim1_bar",".png",sep="")
  png(filename=filepath9)
  print(fviz_contrib( res.ca, choice = "row", axes = 1,top=10))
},warning = function(w) {
  print(w)
},error = function(e) {
  print(e)
},finally = {
  if (dev.cur()>1)
    dev.off()
})
chart.filepaths <- c(chart.filepaths,paste("ca_rows_contrib_dim1_bar",filepath9,sep=","))

tryCatch({
  filepath10 <- paste(charts.dir,"ca_rows_contrib_dim2_bar",".png",sep="")
  png(filename=filepath10)
  print(fviz_contrib( res.ca, choice = "row", axes = 2,top=10))
},warning = function(w) {
  print(w)
},error = function(e) {
  print(e)
},finally = {
  if (dev.cur()>1)
    dev.off()
})
chart.filepaths <- c(chart.filepaths,paste("ca_rows_contrib_dim1_bar",filepath10,sep=","))

# rows total contribution to Dim1 and Dim2
# red dashed line on the graph indicates the expected average value, if the contributions were uniform
tryCatch({
  filepath11 <- paste(charts.dir,"ca_rows_contrib_dim12_bar",".png",sep="")
  png(filename=filepath11)
  print(fviz_contrib( res.ca, choice = "row", axes = 1:2,top=10))
},warning = function(w) {
  print(w)
},error = function(e) {
  print(e)
},finally = {
  if (dev.cur()>1)
    dev.off()
})
chart.filepaths <- c(chart.filepaths,paste("ca_rows_contrib_dim1_bar",filepath11,sep=","))

# scatter plot with gradient colors to show the importance of contribution
tryCatch({
  filepath12 <- paste(charts.dir,"ca_rows_contrib_scatterplot",".png",sep="")
  png(filename=filepath12)
  print(fviz_ca_row( res.ca, col.row = "contrib", gradient.cols = c("#00AFBB", "#E7B800", "#FC4E07"), repel = TRUE))
},warning = function(w) {
  print(w)
},error = function(e) {
  print(e)
},finally = {
  if (dev.cur()>1)
    dev.off()
})
chart.filepaths <- c(chart.filepaths,paste("ca_rows_contrib_scatterplot",filepath12,sep=","))

print("End analysis of individuals (observations or rows)")
cat("\n\n")
##### END - GRAPHIC ANALYSIS OF ROW OBSERVATIONS ####################################################################

##### START - GRAPHIC ANALYSIS OF COLUMN VARIABLES ##################################################################
print("Start analysis of variables (columns or attributes)")
col.ca <- get_ca_col(res.ca)
# col.ca

print("(CONT'D) Parameters in the new (Orthogonal, uncorrelated) space")
print("Top Columns Coordinates")
head(col.ca$coord)
cat("\n\n")
print("Top Columns Squared Correlations")
head(col.ca$cos2)
cat("\n\n")
print("Top Columns Contributions")
head(col.ca$contrib)
cat("\n\n")
print("Top Columns Data Inertia (or Variance)")
head(col.ca$inertia)
cat("\n\n")
#fviz_ca_col(res.ca)

# scatter plot with gradient colors to show the importance of contribution
tryCatch({
  filepath13 <- paste(charts.dir,"ca_cols_cos2_plot",".png",sep="")
  png(filename=filepath13)
  print(fviz_ca_col(res.ca, col.col = "cos2", gradient.cols = c("#00AFBB", "#E7B800", "#FC4E07"), repel = TRUE)
        + labs(title="Plotted View: Quality of Representation of Observations and Variables in Reduced Dimensions Space"))
},warning = function(w) {
  print(w)
},error = function(e) {
  print(e)
},finally = {
  if (dev.cur()>1)
    dev.off()
})
chart.filepaths <- c(chart.filepaths,paste("ca_cols_cos2_plot",filepath13,sep=","))

tryCatch({
  filepath14 <- paste(charts.dir,"ca_cols_cos2_bar",".png",sep="")
  png(filename=filepath14)
  print(fviz_cos2(res.ca,choice="col",axes=1:2))
},warning = function(w) {
  print(w)
},error = function(e) {
  print(e)
},finally = {
  if (dev.cur()>1)
    dev.off()
})
chart.filepaths <- c(chart.filepaths,paste("ca_cols_cos2_bar",filepath14,sep=","))

tryCatch({
  filepath15 <- paste(charts.dir, "ca_asymmetric_biplot", ".png", sep = "", res = 75)
  png(filename = filepath15, width = 650, height = 650, units = "px")
  print(fviz_ca_biplot(res.ca, map = " rowprincipal", arrow = c(TRUE, TRUE), repel = TRUE)
        +labs(title="View of Observations and Variables Representation in Reduced Dimensions Space (Normalized)"))
},warning = function(w) {
  print(w)
},error = function(e) {
  print(e)
},finally = {
  if (dev.cur()>1)
    dev.off()
})
chart.filepaths <- c(chart.filepaths,paste("ca_asymmetric_biplot",filepath15,sep=","))

print("End analysis of variables (attributions or rows)")
cat("\n\n")
##### END - GRAPHIC ANALYSIS OF COLUMN VARIABLES ####################################################################

chart.filepaths <- c("CHART_FILES,15",chart.filepaths)

print("Following charts have been generated for this analysis session:")
print(chart.filepaths)
sessionInfo()

