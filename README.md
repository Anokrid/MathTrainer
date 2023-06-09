# MathTrainer
Один из моих старых проектов, для которого я причесал код. Проект предназначен для помощи в тренировке счёта в уме и рассчитан на такие математические операции, как сложение, вычитание, умножение, деление, возведение в степень и извлечение корня. Программа генерирует примеры на заданные операции с числами разрядностью от 1 до 7. ПРи этом на числа, которые участвуют в примерах, можно накладывать фильтры, например число будет чётным или нечётным, определённые разряды будут равны между собой, или некоторые разряды будут давать в сумме определённое число. После генерации примеров можно посмотреть ответы к составленным примерам. 

Проект написан на C# c использованием WInForms.
## Основное окно программы ##
Основное окно программы выглядит следующим образом:
![Основное окно](https://user-images.githubusercontent.com/35272981/232142961-260ad520-f577-4385-85c9-88cdd208f62a.png)

В самой верхней части окна имеется меню, позволяющее открывать следующие дочерние окна:
1) О приложении
2) Помощь с работой
3) Настройки
4) Заметки
5) История версий

В верхней части приложения задаются числа m и n, отвечающие за разрядность чисел, генерируемых в примерах, а также выбирается математическая операция, на которую будут генерироваться примеры. В правой части включается/отключается использование фильтров, а также осуществляется их выбор, создание, редактирование и удаление.

## Фильтры для генерируемых чисел ##

Как было сказано ранее, для чисел можно задавать различные фильтры. Фильтрация применяется для каждой цифры каждого числа по отдельности. Доступны следующие типы фильтров:
| Текстовый фильтр | Описание |
|----------------|---------|
| R | Цифра будет случайной |
| от 0 до 9 | Цифра будет иметь конкретное указанное значение |
| 2N | Цифра будет чётной |
| !2N | Цифра будет нечётной |
| от S1 до S5 | Цифры, к которым применён данный фильтр, в сумме будут давать число, указанное пользователем для сумм S1-S5 |
| = | Цифра одного числа будет равна цифре второго числа, стоящей на том же разряде |
| <=, => | Цифра числа будет равна цифре слева/справа |
| от =1 до =7 | Цифра будет равна цифре, стоящей на указанном разряде |

Окно создания/редактирования фильтров выглядит так:
![Фильтры](https://user-images.githubusercontent.com/35272981/232144089-e777f838-9a08-43fb-8572-e28e6b83bfa7.png)

Таким образом, применив фильтр, указанный на изображении, при генерации примеров, числа А и В будут обладать следующими характеристиками:
1) Число А будет чётным, его тысячи будут равны тысячам второго числа В, а сотни всегда будут равны 0
2) Число В будет нечётным, его сотни всегда будут равны 9
3) Сумма десятков чисел А и В будет равна 7
