Веб-сервис на ASP.NET Core, реализующий 2 API метода:
1. GET/currencies - возвращает список курсов валют с возможной пагинацией (дополнительно в заголовки выводятся метаданные пагинации);
2. GET/currency/ - возвращает курс валюты по индетификатору этой валюты (идентификатор является обязательным параметром, в случае передачи неправильного идентификатора выводится объект с значениями null, метод не чувствителен к регистру).
