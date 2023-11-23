
# Simple Tests Application for Universities and Schools

## Overview

Simple Test Application is a basic application developed for a university. It is a straightforward and quickly implemented tool designed to assist in generating and taking tests. The application is written in C# using Visual Studio and Python for generating tests, and features a simple user interface.

## Features

- **User-Friendly Interface:** The application provides an easy-to-use interface for choosing and taking tests

- **No Database Dependency:** Simple Test Generator operates without a database. It utilizes arrays of "question" objects to store test data, eliminating the need for a database setup.

- **Customizable Tests:** Users can easily modify the test content by adjusting the arrays of "question" objects directly in the code.

- ***Custom Questions Genrator written in Python:*** Users can easily generate test from text by my simple questions generator. You can learn more ![here](/simple_questions_gen)!

- ### Ui samples
![Test UI](/images/ui1.png)
![Choose test UI](/images/ui2.png)
![Check answers UI](/images/ui2.png)
## Usage

### Changing Test Content

To modify the test content, follow these steps:

1. Open the project in Visual Studio.
2. Locate the `ChooserFrame.cs` file.
3. Find the `listBox1.Items.Add` section in the code and change the names of your tests. You can add or deleat names and entries if you need.
4. Load your text of test in my ![simple_questions_gen](/simple_questions_gen)!
5. Update the test content by adding or modifying the `Question` objects. For example, in `ControlTest.cs`:

```csharp
new Question(
    "Question",
    "Variants",
    "Answer"
),
```

5. Save the changes.

### Running the Application

Build and run the application in Visual Studio to use the updated test content.

## Note

This application was developed for educational purposes, and its simplicity is intentional. It does not rely on a database to store test data for reasons such as the nature of the original test material, time constraints, and security considerations to prevent unauthorized access to test content.

## License

This project is open-source and is provided under the [MIT License](LICENSE).
