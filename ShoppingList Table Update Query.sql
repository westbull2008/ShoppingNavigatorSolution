create table product_shopping_list (
	listId int NOT NULL,
	productId INT NOT NULL,
	quantity int DEFAULT 1,

	CONSTRAINT pk_product_shopping_list_listId_productId PRIMARY KEY (listId, productId),
	CONSTRAINT fk_product_shopping_list_products FOREIGN KEY (productId) REFERENCES products(id),
	CONSTRAINT fk_product_shopping_list_shopping_list FOREIGN KEY (listId) REFERENCES shopping_list(listId)

);

create table shopping_list (
	ListId INT identity (1,1) NOT NULL,
	ListDate DATE NOT NULL,
	ListName VARCHAR(50) NOT NULL,

	CONSTRAINT pk_shopping_list PRIMARY KEY (ListId)

);
ALTER table product_shopping_list
ADD FOREIGN KEY (ListId)
REFERENCES shopping_list(ListId);

select *
from products;

ALTER table products
ADD CONSTRAINT fk_products_product_shopping_list FOREIGN KEY (id) REFERENCES product_shopping_list(productId);

ALTER TABLE product_shopping_list
ADD CONSTRAINT fk_product_shopping_list_products FOREIGN KEY (productId) REFERENCES products(id);


ALTER TABLE product_shopping_list
ADD CONSTRAINT fk_product_shopping_list_shopping_list FOREIGN KEY (listId) REFERENCES shopping_list(listId);

ALTER TABLE product_shopping_list
ADD FOREIGN KEY(listId)
REFERENCES shopping_list(listId);

ALTER TABLE products
ADD CONSTRAINT pk_products_product PRIMARY KEY (id);
