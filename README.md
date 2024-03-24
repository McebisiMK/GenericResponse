# GenericResponse
Wraps all errors, info messages and data into one object. IsValid indicates whether the response is successful or not, Messages are used to log the steps or flow of API execution and errors contain all occurred errors.

---
### [Extensions](https://github.com/McebisiMK/GenericResponse/tree/main/Extensions)
- [CustomExtensions](https://github.com/McebisiMK/GenericResponse/blob/main/Extensions/CustomExtensions.cs)
    - **IsEmpty**: Boolean string extension method to check whether a string is empty.
    - **HasValue**: Boolean string extension method to check whether a string has a value.
    - **Clear**: Clears the items in a list. 

---
### [Models](https://github.com/McebisiMK/GenericResponse/tree/main/Models)
- [Response](https://github.com/McebisiMK/GenericResponse/blob/main/Models/Response.cs)
    - **Properties**
        - **IsValid**: Indicates whether the response is successful or not based on List of Errors. It's treated invalid if it has errors.
        - **Errors**: List of error messages that occurred during the execution of the application.
        - **Messages**: List of info messages which can be used to log the flow (steps) of the applications. 
    
    - **Methods**
        - **AddError**: Adds an error message to the response.
        - **AddMessage**: Adds an info message to the response.
        - **ClearErrors**: Clears all error messages from the response.
        - **ClearMessages**: Clears all info messages from the response.
        - **MergeResponses**: Copies over all error and info messages from one response to the other. 
        - **MergeResponseWithData**: Copies over all error and info messages from one response to the other and returns the response Data (Body).

- [Response<T>](https://github.com/McebisiMK/GenericResponse/blob/main/Models/Response.cs): Inherits from **Response**
    - **Data**: This is the body of the response. 
---

**Responses:**
- **Happy cases:**
    <br/><br/>
    **Array of strings**
    ```
    {
        "data": [
            "First",
            "Second"
        ],
        "isValid": true,
        "errors": [],
        "messages": [
            "First info message",
            "Second info message"
        ]
    }
    ```
    
    **Array of objects**
    ```
    {
        "data": [
            {
                "name": "Test",
                "lastName": "Tester"
            },
            {
                "name": "Test 2",
                "lastName": "Tester 2"
            }
        ],
        "isValid": true,
        "errors": [],
        "messages": [
            "Retrieving employees",
            "Retrieved employees"
        ]
    }
    ```

    **Single object**
    ```
    {
        "data": {
            "name": "Test 2",
            "lastName": "Tester 2"
        },
        "isValid": true,
        "errors": [],
        "messages": [
            "Retrieving employee details",
            "Retrieved employee details"
        ]
    }
    ```

    **Value response**
    ```
    {
        "data": "05/05/2005",
        "isValid": true,
        "errors": [],
        "messages": [
            "Retrieving employee date of birth",
            "Retrieved employee date of birth"
        ]
    }
    ```

    **Void response**
    ```
    {
        "isValid": true,
        "errors": [],
        "messages": [
            "Adding employee details",
            "Added employee details"
        ]
    }
    ```
- **Sad Case**
    ```
    {
        "isValid": false,
        "errors": [
            "Something happened while adding employee details. Error: A network-related or instance-specific error occurred while establishing a connection to SQL Server."
        ],
        "messages": [
            "Adding employee details"
        ]
    }
    ```
