-- SQL ������ ��� ������ ���� ��� ���� �������� � ��� ���������
-- ���� � �������� ��� ���������, �� ��� ��� ��� ����� ������ ����������

SELECT products.Name, categories.Name 
FROM Products products
LEFT JOIN ProductsCategories productsCategories ON products.Id = productsCategories.ProductId
LEFT JOIN Categories categories ON categories.Id = productsCategories.CategoryId