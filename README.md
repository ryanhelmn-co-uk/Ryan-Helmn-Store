# Ryan-Helmn-Store
Open source Umbraco Vendr application which exposes an API for a mobile app.

# Mobile App
iOS built in SwiftUI

# Resources
Mobile app design from UpLabs: https://www.uplabs.com/posts/ecommerce-app-design-23d6401d-0811-4f6f-a94a-d3fe98a68d72
Website template from Bootstrapious: https://bootstrapious.com/p/boutique-bootstrap-e-commerce-template

# Login
Username: dev@email.com
Password: LetDevIn123!

# Third Party
Vendr: https://github.com/vendrhub/vendr
E-commerce solution

Umbraco Headreset: https://github.com/mattbrailsford/umbraco-headrest
Converts Umbraco front end into a REST API utilising modelsbuilder which allows the mobile app to communicate with the website and easily retrieve content.

uSync: https://github.com/KevinJump/uSync
Makes deployments simpler between environments

# Setup
To get started
1. You'll want to restore the bacpac into your SQL server.
2. Once that's done, navigate to RyanHelmnStore.Web/Config and rename the 'ConnectionStrings.empty.config' to 'ConnectionStrings.config' and update the database credentials.
I've set this up like this as the main ConnectionStrings.config is excluded from the repo. Feel free to include this in your *private* repository.