-- SQL запрос для выбора всех пар «Имя продукта – Имя категории»
-- Если у продукта нет категорий, то его имя все равно должно выводиться

SELECT products.Name, categories.Name 
FROM Products products
LEFT JOIN ProductsCategories productsCategories ON products.Id = productsCategories.ProductId
LEFT JOIN Categories categories ON categories.Id = productsCategories.CategoryId