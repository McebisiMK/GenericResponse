# GenericValidatableResponse
Wraps all errors, info messages and data into one object. IsValid indicates whether the response is successful or not, Messages are used to log the steps or flow of API execution and errors contain all occurred errors.

---
### [Extensions](https://github.com/McebisiMK/GenericValidatableResponse/tree/main/Extensions)
- [CustomExtensions](https://github.com/McebisiMK/GenericValidatableResponse/blob/main/Extensions/CustomExtensions.cs)
    - **IsEmpty**: Boolean string extension method to check whether a string is empty.
    - **HasValue**: Boolean string extension method to check whether a string has a value.
    - **Clear**: Clears the items in a list. 

---
### [Models](https://github.com/McebisiMK/GenericValidatableResponse/tree/main/Models)
- [ValidatableResponse](https://github.com/McebisiMK/GenericValidatableResponse/blob/main/Models/ValidatableResponse.cs)
    - **Properties**
        - **IsValid**: Indicates whether the response is successful or not based on List of Errors. It's treated invalid if it has errors.
        - **Errors**: List of error messages that occurred during the execution of the application.
        - **Messages**: List of info messages which can be used to log the flow (steps) of the applications. 
    
    - **Methods**
        - **AddError**: Adds an error message to the response.
        - **AddError**: Adds an info message to the response.
        - **ClearErrors**: Clears all error messages from the response.
        - **ClearMessages**: Clears all info messages from the response.
        - **MergeResponses**: Copies over all error and info messages from one response to the other. 
        - **MergeResponseWithData**: Copies over all error and info messages from one response to the other and returns the response Data (Body).

- [Response](https://github.com/McebisiMK/GenericValidatableResponse/blob/main/Models/Response.cs): Inherits from **ValidatableResponse**
    - **Data**: This is the body of the response. 
---