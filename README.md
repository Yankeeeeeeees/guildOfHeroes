## Собственный проект

Тема проекта: Практическая работа N9

Главный класс: Computer

Почему этот объект нужен программе:
На нем основывается все

Какие данные хранит объект:

- Бренд
- Корпус
- Процессор
- Видеокарта
- ОЗУ
- Блок питания

Какие значения задаются через конструктор:
- Корпус
- Процессор
- Видеокарта
- ОЗУ
- Блок питания

Какие значения можно задавать автоматически:
- Бренд


1. Метод экземпляра и поле. Поле хранит данные, метод их меняет или читает. Поле: public int Health; в Hero.cs. Метод: public void TakeDamage(int damage) в Hero.cs. Поле вызывается без скобок, метод со скобками.

2. Значение в параметр. Вызов yaroslav.TakeDamage(25) в Program.cs копирует 25 в damage внутри TakeDamage.

3. void. Метод ничего не возвращает. Пример: public void Heal(int amount) в Hero.cs.

4. return; и return Health > 0;. return; просто выходит из метода void, как в if (damage <= 0) { return; } в TakeDamage. return Health > 0; возвращает значение bool, как в IsAlive().

5. bool и IsAlive(). bool принимает true или false. Ответ сохраняется так, как в Program.cs: bool yaroslavAlive = yaroslav.IsAlive();.

6. Строка и вывод. В Computer.cs метод GetInfoComp() возвращает строку, а Console.WriteLine вызывается в Program.cs. Так метод не зависит от того, куда выводится текст.

7. Один герой меняется. В TakeDamage поле Health относится к объекту, у которого вызван метод. В yaroslav.TakeDamage(25) меняется только yaroslav.Health.

8. Обход проверок. Поля public, поэтому в Program.cs можно написать yaroslav.Health = 75; напрямую, и проверки из TakeDamage не сработают. Защита: сделать поля private и оставить доступ через методы.