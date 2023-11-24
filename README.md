
# Simple Tests Application for Universities and Schools

## Overview

Simple Test Application is a basic application developed for a university. It is a straightforward and quickly implemented tool designed to assist in generating and taking tests. The application is written in C# using Visual Studio and Python for generating tests, and features a simple user interface.

## Features

- **User-Friendly Interface:** The application provides an easy-to-use interface for choosing and taking tests

- **No Database Dependency:** Simple Test Generator operates without a database. It utilizes arrays of "question" objects to store test data, eliminating the need for a database setup.

- **Customizable Tests:** Users can easily modify the test content by adjusting the arrays of "question" objects directly in the code.

- ***Custom Questions Generator written in Python:*** Users can easily generate test from text by my simple questions generator. You can learn more ![here](/simple_questions_gen)!

- ### Ui samples
![Test UI](/images/ui1.png)
![Choose test UI](/images/ui2.png)
![Check answers UI](/images/ui3.png)
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

# Simple Text-Based Question Generator

This simple Python script is designed for generating text-based questions and answers. It includes three types of question generators: Simple Question, Hard Question, and Chooser Question.

## Usage

1. **Simple Question Generator**
    - Reads from a text file and generates questions with a single correct textual answer.
    - Example input:
        ```
        Укажите правильный ответ.
        «Столица России»
        Ответ: Москва
        ```
    - Output:
        ```python
        new Question(
            "Укажите правильный ответ.\nОтвет пишите с маленькой буквы",
            "Столица России",
            "Москва"
        ),
        ```

2. **Chooser Question Generator**
    - Reads from a text file and generates multiple-choice questions with a designated correct answer.
    - Example input:
        ```
        Укажите правильный ответ:
        Понятийное мышление -
        конкретно
        абстрактно +
        образно
        символично
        ```
    - Output:
        ```python
        new Question(
                    "Укажите правильный ответ.\r\nВ качестве ответа введите цифру.\r\nПонятийное мышление -:",
                    "1) Конкретно \r\n2) Абстрактно\r\n3) Образно\r\n4) Символично",
                    "2"
                ),
        ```

3. **Hard Question Generator**
    - Reads from a text file and generates matching questions with a specific order of correct answers.
    - Example input:
        ```
        Установите соответствие между контекстами и выражениями так, чтобы получились истинные высказывания:
        Контекст                                                                Выражение
        ... - город Европейской части России (2)                                1. «Москва»
        ... - название города (1)                                               2. Москва
        ... - выражение русского языка (4)                                      3. «Столица России»
        ... - выражение, обозначающее слово (3)                                 4. ««Москва»»
                                                                                5. Столица России
        ```
    - Output:
        ```python
          ,new Question(
                  "Укажите правильный ответ.\r\nВ качестве ответа пишите цифры по порядку без пробелов и запятых (1231).\r\nУстановите соответствие между контекстами и выражениями так, чтобы получились истинные высказывания:",
                  "1. ... - город Европейской части России \n2. ... - название города \n3. ... - выражение русского языка \n4. ... - выражение, обозначающее слово\r\n\n1. «Москва»\n2. Москва\n3. «Столица России»\n5. ««Москва»»\n6. Столица России",
                  "2143"
                ),
        ```

## How to Use

1. Save your question data in a text file (e.g., '01.txt') according to the specified format.
2. Run the script and choose the type of question you want to generate.

## Running the Script

```bash
python script_name.py
```

Follow the on-screen prompts to generate questions based on your chosen type.

This project is open-source and is provided under the MIT License.
