
# Примеры кода

## Как узнать информацию о своём Боте?

Достаточно обратиться к нужным Свойствам просто по названию:
X, Y, Name, Health, BombsCount...
```
Пример 1: находится ли Бот в центре:

 public override PlayerAction Play(GameBoard gb)
 {
   ...

   if (X==gb.W/2 && Y == gb.H/2)
   {
      Console.WriteLine("Бот в центре поля");
   }
   
   ...
}

Пример 2: узнать Радиус взрыва своих Бомб:

 public override PlayerAction Play(GameBoard gb)
 {
   ...

   Console.WriteLine(Radius);
   
   ...
}




```


## Как проверить пустая ли клетка?
Если хотим проверить клетку с координатами [5;5]
```
 public override PlayerAction Play(GameBoard gb)
 {
   ...

   if (gb.XYinfo[5,5].Free == true)
   {
      Console.WriteLine("Клетка [5,5] - пустая");
   }
   
   ...
}
```


## 2) Как проверить какая постройка находится в указанной клетке?
Если хотим проверить клетку с координатами [5;5]

```
 public override PlayerAction Play(GameBoard gb)
 {
   ...
 
     if (gb.XYinfo[5,5].Type == CellType.Destructible)
     {
         Console.WriteLine("Клетка с разрушаемой постройкой, может быть под ней скрытый Бонус");
     }
     else if (gb.XYinfo[5,5].Type == CellType.Indestructible)
     {
         Console.WriteLine("Клетка с Неразрушаемой постройкой");
     }
     else if (gb.XYinfo[5,5].Type == CellType.None)
     {
         Console.WriteLine("Клетка без построек, но возможно с другими игровыми объектами");
     }
   }  
   
   ...
}
```


## Как узнать есть ли в указанной клетке Бонус, а также узнать его Тип?
Если хотим проверить клетку с координатами [5;5]

```
 public override PlayerAction Play(GameBoard gb)
 {
   ...
 
     if (gb.XYinfo[5,5].Bonus != null) // Есть ли в клетке Бонус
     {
         if (gb.XYinfo[5,5].Bonus.Type == BonusType.Ammunition)
         {
             Console.WriteLine("В клетке находится бонус - Склад Бомб");
         }
         else if (gb.XYinfo[5,5].Bonus.Type == BonusType.Radius){
            Console.WriteLine("В клетке находится бонус - Запас Дикого огня");
         }         
     }  
   
   ...
}
```

## Как узнать, кто из Ботов жив?

```
 public override PlayerAction Play(GameBoard gb)
 {
   ...
 
    for (int i = 0; i < gb.Players.Count; i++)
    {
        var tplayer = gb.Players[i];

        if (tplayer.Health>0)
        {
            Console.WriteLine("Бот " + tplayer.Name + " жив");
        }
        else
        {
            Console.WriteLine("Бот " + tplayer.Name + " мёртв");
        }
    }
   
   ...
}
```

