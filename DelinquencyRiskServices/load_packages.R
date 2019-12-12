if (!is.element('FactoMineR', installed.packages(lib.loc = './Rpackages')[,1]))
{
  install.packages('FactoMineR', lib = './Rpackages', repos = 'http://cran.rstudio.com/')
  cat("Installed package FactoMiner.")
} else {
  cat('Package FactoMineR already installed.')
}

cat("\n")
if (!is.element('factoextra', installed.packages(lib.loc = './Rpackages')[,1]))
{
  install.packages('factoextra', lib='./Rpackages', repos='http://cran.rstudio.com/')
  cat("Installed package factoextra.")
} else {
  cat('Package factoextra already installed.')
}
cat("\n")
if (!is.element('gplots', installed.packages(lib.loc = './Rpackages')[,1]))
{
  install.packages('gplots', lib='./Rpackages', repos='http://cran.rstudio.com/')
  cat("Installed package gplots.")
} else {
  cat('Package gplots already installed.')
}
cat("\n")
if (!is.element('corrplot', installed.packages(lib.loc = './Rpackages')[,1]))
{
  install.packages('corrplot', lib='./Rpackages', repos='http://cran.rstudio.com/')
  cat("Installed package corrplot.")
} else {
  cat('Package corrplot already installed.')
}
cat("\n")
if (!is.element('ggpubr', installed.packages(lib.loc = './Rpackages')[, 1])) {
    install.packages('ggpubr', lib = './Rpackages', repos = 'http://cran.rstudio.com/')
    cat("Installed package ggpubr.")
} else {
    cat('Package ggpubr already installed.')
}
