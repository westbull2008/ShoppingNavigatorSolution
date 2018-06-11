select *
from shopping_list;

select *
from shopping_list
join product_shopping_list on shopping_list.listId = product_shopping_list.listId
join products on product_shopping_list.productId = products.id
where shopping_list.listId = 1;

select *
from product_shopping_list;

INSERT INTO product_shopping_list (listId, productId, quantity) VALUES (13, 92, 1)

insert into product_shopping_list (listId, productId, quantity)
values (1, 92, 1), (1, 45, 2);

select * from shopping_list 
join product_shopping_list on shopping_list.listId = product_shopping_list.listId 
join products on product_shopping_list.productId = products.id 
where shopping_list.listId = 1;