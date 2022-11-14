Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Блок-схема:

![](Diagram.png)

**Алгоритм решения:**

* Делаем перебор значений из исходного массива

* Проверяем каждый элемент массива соласно условию:

    *длина строки меньше, либо соответствует трём символам*
* При соблюдении условия, заносим элемент в новый массив
* Повторяем действия до последнего элемента
* **Выводим полученный массив**