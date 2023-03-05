MVVM (Model-View-ViewModel) is a software architecture pattern that is commonly used in the development of modern user interfaces.
It separates the UI logic and presentation from the underlying data model and business logic.

The Model is responsible for holding the data and business logic. The View is responsible for the presentation of the UI.
The ViewModel acts as the mediator between the Model and the View. It provides data binding between the UI elements and the data model, and it contains the logic for the UI behaviors.

------------------------------------------------------------------------------------------------------------------
In this example, the Model contains the ProductModel class, which holds the data for a product.
The ViewModel contains the ProductViewModel class, which contains the Products property and the logic for adding a new product.
The View contains the MainWindow class, which sets the DataContext to the ProductViewModel instance and handles the click event for the Add button.