


using Learning.DelegatesHomework;

public class Program
{
    static void Main(string[] args)
    {
        Notifier notifier = new Notifier();

        // Подписываем метод Console.WriteLine на делегат
        notifier.OnNotify = Console.WriteLine;

        // Можно добавить ещё один обработчик
        notifier.OnNotify += PrintMessage;

        // Отправляем уведомление
        notifier.SendNotification("Привет, это тестовое уведомление!");

        // Создаём слушателей
        Listener listener1 = new Listener();
        Listener listener2 = new Listener();
        Listener listener3 = new Listener();

        // Подписываем слушателей на NotifyEvent
        notifier.NotifyEvent += listener1.OnNotificationReceived;
        notifier.NotifyEvent += listener2.OnNotificationReceived;
        notifier.NotifyEvent += listener3.OnNotificationReceived;

        Console.WriteLine("\n--- Запуск тестового события ---");
        notifier.TriggerEvent("Запуск тестового события");

        // Убираем второго и третьего подписчика
        notifier.NotifyEvent -= listener2.OnNotificationReceived;
        notifier.NotifyEvent -= listener3.OnNotificationReceived;

        Console.WriteLine("\n--- Событие после отписки некоторых слушателей ---");
        notifier.TriggerEvent("Запуск тестового события");

        Console.WriteLine("\n--- Последнее тестовое событие ---");
        notifier.TriggerEvent("Пуск");

        Console.WriteLine("\nГотово!");
    }

    public static void PrintMessage(string message)
    {
        Console.WriteLine($"[PrintMessage]: {message}");
    }
}

