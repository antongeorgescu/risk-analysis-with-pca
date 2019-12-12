# What is Principal Component Analysis (PCA)?
Principal Component Analysis (PCA) is a dimensionality-reduction technique that is often used to transform a high-dimensional dataset into a smaller-dimensional subspace prior to running a machine learning algorithm on the data. 
Principal Component Analysis does just what it advertises; it finds the principal components of the dataset. PCA transforms the data into a new, lower-dimensional subspace—into a new coordinate system—. In the new coordinate system, the first axis corresponds to the first principal component, which is the component that explains the greatest amount of the variance in the data. 

# What is this project doing?
This project implements a "delinquency risk analysis" among some imaginary students wjo have to pay their study loans back. The attributes, that are created only for demo purposes and have no bearing to reality, contain things like loan amount, student hoe province, student age etc. The most importants factors are getting selected and the risk of going delinquent is calcylated based on the prevalence of these factors for each student. 

# What is this project using?
This project combines the power of .NET interfaces and a set of R packages, among whihc the primary is **factoextra**
**factoextra**  is an R package making easy to extract and visualize the output of exploratory multivariate data analyses, including:
* **Principal Component Analysis (PCA)**, which is used to summarize the information contained in a continuous (i.e, quantitative) multivariate data by reducing the dimensionality of the data without loosing important information.
* **Correspondence Analysis (CA)**, which is an extension of the principal component analysis suited to analyse a large contingency table formed by two qualitative variables (or categorical data).
* **Multiple Correspondence Analysis (MCA)**, which is an adaptation of CA to a data table containing more than two categorical variables.
* **Multiple Factor Analysis (MFA)** dedicated to datasets where variables are organized into groups (qualitative and/or quantitative variables).
* **Hierarchical Multiple Factor Analysis (HMFA)**: An extension of MFA in a situation where the data are organized into a hierarchical structure.
* **Factor Analysis of Mixed Data (FAMD)**, a particular case of the MFA, dedicated to analyze a data set containing both quantitative and qualitative variables.
