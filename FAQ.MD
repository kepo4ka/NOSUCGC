
# Примеры кода

## 1) Как узнать информацию о своём Боте?

Достаточно обратиться к нужным Свойствам просто по названию:
X, Y, Name, Health, BombsCount...
```
Пример: проверка находится ли Бот в центре:

 public override PlayerAction Play(GameBoard gb)
 {
...

   if (X==gb.W/2 && Y == gb.H/2)
   {
      Console.WriteLine("Бот в центре поля");
   }
   
...
}

```
