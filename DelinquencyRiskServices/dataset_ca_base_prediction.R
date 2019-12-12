curr.loc <- paste(getSrcDirectory(function(x) {x}),"RPackages",sep="")
library("FactoMineR",lib.loc=curr.loc)
library("factoextra",lib.loc=curr.loc)
library("gplots",lib.loc=curr.loc)
library("corrplot",lib.loc=curr.loc)
library("ggpubr", lib.loc = curr.loc)
library(utils,lib.loc=curr.loc)

#library("FactoMineR")
#library("factoextra")
#library("gplots")
#library("corrplot")

#if (!require(FactoMineR)) {
#    install.packages("FactoMineR")
#    library(FactoMineR)
#}

#if (!require(factoextra)) {
#    install.packages("factoextra")
#    library(factoextra)
#}

#if (!require(gplots)) {
#    install.packages("gplots")
#    library(gplots)
#}

#if (!require(corrplot)) {
#    install.packages("corrplot")
#    library(corrplot)
#}

file.path <- getSrcDirectory(function(x) {x})
charts.dir <- paste(file.path,"plots/",sep="")

print("Extract external data into contingency table")

dataset.file.name <- "delinquents_take_5a.txt"
print(paste("Source file ",dataset.file.name," analyzed on ",Sys.time(),sep=""))

data.file.path <- paste(file.path,"datasets/",dataset.file.name,sep="")
ht.data <- read.delim(data.file.path, header=TRUE, row.names=1,sep=",")
dt <- as.table(as.matrix(ht.data))

chart.filepaths <- c()

res.ca <- CA(ht.data,graph=FALSE)
eig.val <- get_eigenvalue(res.ca)
print("-1A-List of Dimensions (aka Eigenvalues)")
print(eig.val)
print("-1Z-")
cat("\n")

row.ca <- get_ca_row(res.ca)
print("Parameters in the new (Orthogonal, uncorrelated) space")
print("-2A-All Rows Contributions")
print(row.ca$cos2)
print("-2Z-")
cat("\n")

tryCatch({
  filepath1 <- paste(charts.dir,"ca_row_asymmetric_biplot",".png",sep="")
  png(filename = filepath1, width = 650, height = 650, units = "px", res = 75)
  print(fviz_ca_biplot( res.ca, map =" rowprincipal", arrow = c( TRUE, TRUE), repel = TRUE) + 
          labs(title="Multi-dimensional Visualization of High Risk Delinquency Factors"))
},warning = function(w) {
  print(w)
},error = function(e) {
  print(e)
},finally = {
  if (dev.cur()>1)
    dev.off()
})
chart.filepaths <- c(chart.filepaths,paste("ca_row_asymmetric_biplot",filepath1,sep=","))

col.ca <- get_ca_col(res.ca)

print("-3A-All Columns Contributions")
print(col.ca$cos2)
print("-3Z-")
cat("\n")

tryCatch({
  filepath2 <- paste(charts.dir,"ca_col_asymmetric_biplot",".png",sep="")
  png(filename = filepath2, width = 650, height = 650, units = "px", res = 75)
  print(fviz_ca_biplot(res.ca, map = " colprincipal", arrow = c(TRUE, TRUE), repel = TRUE) + 
          labs(title="Multi-dimensional Visualization of High Risk Delinquency Factors"))
},warning = function(w) {
  print(w)
},error = function(e) {
  print(e)
},finally = {
  if (dev.cur()>1)
    dev.off()
})
chart.filepaths <- c(chart.filepaths,paste("ca_col_asymmetric_biplot",filepath2,sep=","))

chart.filepaths <- c("CHART_FILES,2",chart.filepaths)

print("Following charts have been generated for this analysis session:")
print(chart.filepaths)


