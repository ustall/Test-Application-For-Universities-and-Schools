# Генератор простых вопросов с ответом в виде текста
# Пример такого вопроса
# Дополните, указав предметное значение имен:
# «Столица России»
# Ответ: Москва
def simple_q_gen(name):
    with open(name, 'r', encoding='utf-8') as file:
        raw = file.read()
        strings = raw.strip().split('\n')
        for i in range(0, len(strings), 3):
            main_question = f"Укажите правильный ответ.\\nОтвет пишите с маленькой буквы\\r\\n{strings[i][2:]}"
            variant = strings[i + 1]
            answer = strings[i + 2].replace("Ответ: ", "")
            question_text = f"new Question(\n \"{main_question}\",\n \"{variant}\",\n \"{answer}\"),"
            print(question_text)
# Генератор вопросов с выбором номера ответа
# Пример такого вопроса + отмечен правильный ответ
# Укажите правильный ответ:
# Понятийное мышление -
# конкретно
# абстрактно +
# образно
# символично
def chooser_q_gen(name):
    with open(name, 'r', encoding='utf-8') as file:
        raw = file.read()
        parts = raw.strip().split('|')
        for part in parts:
            strings = part.strip().split('\n')
            # for i in range (len(strings)):
            main_question = f"{strings[0]}\\n{strings[1]}"
            variant = f"{strings[2]}\\n"
            answer = ""
            for i in range(3, len(strings) - 1):
                for j in range(len(strings[i])):
                    if strings[i][j] == "+":
                        answer += f"{i - 2}"
                        strings[i] = strings[i][:j] + strings[i][j + 1:]
                variant = variant + f"\\n{i - 2}. {strings[i]}"
            question_text = f"new Question(\n \"{main_question}\",\n \"{variant}\",\n \"{answer}\"),"
            print(question_text)
# Генератор вопросов с выбором соответсвуюзих номеров попорядку
# Пример такого вопроса в скобках правильный ответ
# Установите соответствие между контекстами и выражениями так, чтобы получились истинные высказывания:
# Контекст                                                                Выражение
# ... - город Европейской части России (2)                                1. «Москва»
# ... - название города (1)                                               2. Москва
# ... - выражение русского языка (4)                                      3. «Столица России»
# ... - выражение, обозначающее слово (3)                                 4. ««Москва»«
#                                                                         5. Столица России
def hard_q_gen(name):
    with open(name, 'r', encoding='utf-8') as file:
        raw = file.read()
        parts = raw.strip().split('|')
        for part in parts:
            strings = part.strip().split('\n')
            main_question = (f"Укажите правильный ответ.\\r\\nВ качестве ответа пишите цифры по порядку без пробелов и "
                             f"запятых(1231).\\n{strings[0].strip()}")
            variant=""
            for j in range(len(strings[1])):
                if strings[1][j] == ":":
                    variant = strings[1][:j] + ":"
                    break
            answer = ""
            for i in range(2, len(strings)):
                for j in range(len(strings[i])):
                    if strings[i][j] == ")":
                        answer = answer + f"{strings[i][j - 1]}"
                        variant = variant + f"\\n{i - 1}. {strings[i][:j - 3]}"
                        break
            for j in range(len(strings[1])):
                if strings[1][j] == ":":
                    variant = variant + f"\\n\\n{strings[1][j + 1:].strip()}"
                    break
            for i in range(2, len(strings)):
                for j in range(len(strings[i])):
                    if strings[i][j] == ".":
                        variant = variant + f"\\n{strings[i][j - 1:]}"
                        break
            question_text = f"new Question(\n \"{main_question}\",\n \"{variant}\",\n \"{answer}\"),"
            print(question_text)
# Вызов функций выбор типа
def console_prompt():
    question_types = {
        "1": "Simple question",
        "2": "Hard question",
        "3": "Chooser question"
    }
    while True:
        print("Choose a question type:")
        for choice, description in question_types.items():
            print(f"{choice}. {description}")
        choice = input("Enter your choice (1, 2, or 3): ")
        if choice in question_types:
            if choice == "1":
                simple_q_gen('01.txt')
            elif choice == "2":
                hard_q_gen('01.txt')
            elif choice == "3":
                chooser_q_gen('01.txt')
            else:
                print("Invalid choice. Please enter a number between 1 and 3.")
        else:
            print("Invalid choice. Please enter a number between 1 and 3.")


if __name__ == '__main__':
    console_prompt()
