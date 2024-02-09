SELECT P.ProductName, C.CategoryName
FROM Products AS P
         LEFT JOIN ProductCategory AS PC ON P.ProductId = PC.ProductId
         LEFT JOIN Categories AS C ON PC.CategoryId = C.CategoryId;

/*
    В этом запросе:

    "Products" — это таблица, содержащая информацию о продуктах.
    "Categories" — это таблица, содержащая информацию о категориях.
    "ProductCategory" — это связующая таблица, которая хранит отношения между продуктами и категориями.
    "ProductName" — это поле в таблице Products, содержащее имя продукта.
    "CategoryName" — это поле в таблице Categories, содержащее имя категории.
    "ProductId" и CategoryId — это поля в связующей таблице ProductCategory, которые используются для связывания продуктов и категорий.

    Оператор "LEFT JOIN" гарантирует, что все продукты будут включены в результаты, даже если у них нет связанных категорий.

*/