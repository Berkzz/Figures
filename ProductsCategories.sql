SELECT p.Name 'Product name', c.Name 'Category name' FROM Products p
LEFT OUTER JOIN ProductsCategories pc on pc.ProductId = p.Id
LEFT OUTER JOIN Categories c ON pc.CategoryId = c.Id;