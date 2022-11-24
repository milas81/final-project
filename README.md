**Итоговая проверочная работа**

**Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.**

Примеры:
```javascript[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
```

**РЕШЕНИЕ:**
Для решения задачи нужно последовательно:

1. Посчитать сколько в исходном массиве элементов с длинной меньше или равной 3.
2. Создать результирующий массив с соответствующей длинной.
3. Заполнить результирующий массив отфильтрованными элементами исходного массива.