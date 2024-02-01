Инструкция по использованию:

Билдим и запускаем UUIDGenerator.App [ConsoleApp]

Далее увидим такой текст:

![img.png](img.png)

Введем путь к файлу (приложение само его создаст, если его нет).

Например, я ввожу: `./uuids.txt`

![img_1.png](img_1.png)

Далее будет предложено выбрать один из вариантов работы приложения: на чтение или запись.

Выберем на запись `Write` mode.

![img_2.png](img_2.png)

Далее мы должны ввести даты в формате `dd.mm.yyyy`, на основе них будут сгенерированы идентификаторы.

Я ввожу несколько дат и пишу `Quit`.

![img_3.png](img_3.png)

Можем увидеть файл, который был создан и заполнен по указанному пути.

![img_4.png](img_4.png)

Далее перезапускаем приложение и переходим в режим чтения `Read`.

![img_5.png](img_5.png)

Приложение просит ввести дату, что бы вывести отсортированные идентификаторы из файла.

![img_6.png](img_6.png)

PS. Мой файл содержит много сгенерированных идентификатор, результат может отличаться.


ВОПРОС 2:

Как мы можем увидеть в приложении - это реализовано. Смотрим файлы `Uuid.cs` и `UuidUtils.cs`.

Об этом можно прочитать в спецификации, https://datatracker.ietf.org/doc/html/rfc4122#section-4.1.2

![img_7.png](img_7.png)
Здесь можно увидеть под какими индексами мы храним и 
сколько бит выделяем под ту или иную часть данных внутри идентификатора.

`Учтите, что записи происходят очень часто и находятся на критическом пути, в то время как чтения достаточно редки (не реализовывайте все, просто опишите).`

Данный шаг в задаче описан не точно, возможно здесь подразумевается многопоточность, но я не стал так усложнять приложение.