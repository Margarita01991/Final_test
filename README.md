**Задача:** Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

>["hello", "2", "world", ":-)"] -> ["2", ":-)"]

>["1234", "1567", "-2", "computer science"] -> [ "-2"]

>["Russia", "Denmark", "Kazan"] -> []

## **Решение задачи:**
1. Массив ***array*** задается на старте выполнения алгоритма.
2. Вводится константа **LIMIT**, с заданным значением **3**, которая будет использована для определения критерия длины символов в массиве.
3. Задаем новый массив ***array2***.
4. С помощью метода ***FillArray*** определяем, какое количество элементов массива ***array*** соответствуют условию задачи.
5. Элементы, удовлетворяющие условию записывются в массив ***array2***
6. Выводим массив ***array2***.
