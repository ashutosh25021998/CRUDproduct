# CRUDproduct
 
Here the CRUD operations done by the async apis with different types of exception handeling

#Steps to run the program 
Create the table in the SqlServerDatabase by running the "product.sql" file.

--Open the Application on VisualStudio.

--Change the servername by changing the connectionstring as the valid servername which is present in the appsettings.json file.
   e.g-
        "ConnectionStrings": { "DefaultConnection": "Server=YourServerName;Database=Product;Trusted_Connection=true;MultipleActiveResultSets=true" }
--Then Connect the Database in the PackageManagerConsole of VisualStudio(Tools->NuGetPackageManager->PackageManagerConsole) by the Command "add-migration test" this will connect and update the database by the EntityFramework.

--Then Run the application and go to this swaggerlink there you can find all the apis for the Crud operation.
 http://localhost:63238/swagger/index.html 
 
 ![image](https://user-images.githubusercontent.com/55780931/142731404-0aa6ee52-0d63-41dd-8faf-3cdcc74e12a9.png)

