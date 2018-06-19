create table products (
	id INT identity(1,1),
	product VARCHAR(200),
	department VARCHAR(50),
);
ALTER TABLE products
ADD CONSTRAINT pk_products_id PRIMARY KEY (id);

SET IDENTITY_INSERT products on
GO


insert into products (id, product, department) values (1, 'Tortillas - Flour, 12', 'Grocery');
insert into products (id, product, department) values (2, 'Beer - Blue', 'Alcohol');
insert into products (id, product, department) values (3, 'Ecolab - Hobart Upr Prewash Arm', 'Grooming Products');
insert into products (id, product, department) values (4, 'Pastry - Raisin Muffin - Mini', 'Bakery');
insert into products (id, product, department) values (5, 'Spaghetti Squash', 'Fruit & Veg');
insert into products (id, product, department) values (6, 'Doilies - 10, Paper', 'Misc');
insert into products (id, product, department) values (7, 'Calypso - Lemonade', 'Beverages');
insert into products (id, product, department) values (8, 'Liners - Banana, Paper', 'Grooming Products');
insert into products (id, product, department) values (9, 'Wine - Lou Black Shiraz', 'Alcohol');
insert into products (id, product, department) values (10, 'Lettuce - Lolla Rosa', 'Fruit & Veg');
insert into products (id, product, department) values (11, 'Oven Mitts 17 Inch', 'Misc');
insert into products (id, product, department) values (12, 'Cheese - Bocconcini', 'Dairy');
insert into products (id, product, department) values (13, 'Soup - Knorr, Country Bean', 'Grocery');
insert into products (id, product, department) values (14, 'Tea - Honey Green Tea', 'Grocery');
insert into products (id, product, department) values (15, 'Water - Spring 1.5lit', 'Beverages');
insert into products (id, product, department) values (16, 'Soup - Campbells Mac N Cheese', 'Grocery');
insert into products (id, product, department) values (17, 'Shrimp - Black Tiger 16/20', 'Frozen');
insert into products (id, product, department) values (18, 'Quiche Assorted', 'Bakery');
insert into products (id, product, department) values (19, 'Turkey Tenderloin Frozen', 'Frozen');
insert into products (id, product, department) values (20, 'Tomato - Plum With Basil', 'Grocery');
insert into products (id, product, department) values (21, '7up Diet, 355 Ml', 'Beverages');
insert into products (id, product, department) values (22, 'Muffin - Mix - Bran And Maple 15l', 'Bakery');
insert into products (id, product, department) values (23, 'Plums - Red', 'Fruit & Veg');
insert into products (id, product, department) values (24, 'Lemons', 'Fruit & Veg');
insert into products (id, product, department) values (25, 'Tofu - Soft', 'Fruit & Veg');
insert into products (id, product, department) values (26, 'Beef - Ox Tongue, Pickled', 'Grocery');
insert into products (id, product, department) values (27, 'Gelatine Leaves - Envelopes', 'Grocery');
insert into products (id, product, department) values (28, 'Broom - Push', 'Misc');
insert into products (id, product, department) values (29, 'Beef Striploin Aaa', 'Meat');
insert into products (id, product, department) values (30, 'Basil - Thai', 'Fruit & Veg');
insert into products (id, product, department) values (31, 'Tea - Green', 'Grocery');
insert into products (id, product, department) values (32, 'V8 Splash Strawberry Banana', 'Beverages');
insert into products (id, product, department) values (33, 'Pasta - Canelloni, Single Serve', 'Grocery');
insert into products (id, product, department) values (34, 'Pork - Sausage, Medium', 'Meat');
insert into products (id, product, department) values (35, 'Rosemary - Dry', 'Grocery');
insert into products (id, product, department) values (36, 'Wine - Red, Mouton Cadet', 'Alcohol');
insert into products (id, product, department) values (37, 'Steampan - Foil', 'Misc');
insert into products (id, product, department) values (38, 'Lobster - Base', 'Meat');
insert into products (id, product, department) values (39, 'Pastry - Key Limepoppy Seed Tea', 'Grocery');
insert into products (id, product, department) values (40, 'Juice - Tomato, 48 Oz', 'Beverages');
insert into products (id, product, department) values (41, 'Pastry - French Mini Assorted', 'Bakery');
insert into products (id, product, department) values (42, 'Appetizer - Escargot Puff', 'Grocery');
insert into products (id, product, department) values (43, 'Lettuce - Boston Bib', 'Fruit & Veg');
insert into products (id, product, department) values (44, 'Toothpick Frilled', 'Grocery');
insert into products (id, product, department) values (45, 'Carbonated Water - Blackberry', 'Beverages');
insert into products (id, product, department) values (46, 'Wine - Beaujolais Villages', 'Alcohol');
insert into products (id, product, department) values (47, 'Clams - Bay', 'Frozen');
insert into products (id, product, department) values (48, 'Broom - Angled', 'Misc');
insert into products (id, product, department) values (49, 'Horseradish - Prepared', 'Grocery');
insert into products (id, product, department) values (50, 'Wine - Red, Harrow Estates, Cab', 'Alcohol');
insert into products (id, product, department) values (51, 'Tea - Grapefruit Green Tea', 'Grocery');
insert into products (id, product, department) values (52, 'Steam Pan Full Lid', 'Misc');
insert into products (id, product, department) values (53, 'Petite Baguette', 'Bakery');
insert into products (id, product, department) values (54, 'Beer - Molson Excel', 'Alcohol');
insert into products (id, product, department) values (55, 'Tomatoes - Cherry', 'Fruit & Veg');
insert into products (id, product, department) values (56, 'Anisette - Mcguiness', 'Alcohol');
insert into products (id, product, department) values (57, 'Apricots Fresh', 'Fruit & Veg');
insert into products (id, product, department) values (58, 'Gelatine Powder', 'Grocery');
insert into products (id, product, department) values (59, 'Beans - Butter Lrg Lima', 'Grocery');
insert into products (id, product, department) values (60, 'Table Cloth 72x144 White', 'Misc');
insert into products (id, product, department) values (61, 'Wine - Magnotta, Merlot Sr Vqa', 'Alcohol');
insert into products (id, product, department) values (62, 'Coffee - Ristretto Coffee Capsule', 'Grocery');
insert into products (id, product, department) values (63, 'Fiddlehead - Frozen', 'Fruit & Veg');
insert into products (id, product, department) values (64, 'Tilapia - Fillets', 'Meat');
insert into products (id, product, department) values (65, 'Muffin - Mix - Creme Brule 15l', 'Grocery');
insert into products (id, product, department) values (66, 'Quail - Whole, Boneless', 'Meat');
insert into products (id, product, department) values (67, 'Ecolab - Orange Frc, Cleaner', 'Cleaning Products');
insert into products (id, product, department) values (68, 'Noodles - Cellophane, Thin', 'Grocery');
insert into products (id, product, department) values (69, 'Container - Foam Dixie 12 Oz', 'Misc');
insert into products (id, product, department) values (70, 'Flour - Masa De Harina Mexican', 'Grocery');
insert into products (id, product, department) values (71, 'Wine - Vineland Estate Semi - Dry', 'Alcohol');
insert into products (id, product, department) values (72, 'Pork - Backfat', 'Meat');
insert into products (id, product, department) values (73, 'Tea - Apple Green Tea', 'Grocery');
insert into products (id, product, department) values (74, 'Cake - Sheet Strawberry', 'Bakery');
insert into products (id, product, department) values (75, 'Salt - Seasoned', 'Grocery');
insert into products (id, product, department) values (76, 'Venison - Racks Frenched', 'Meat');
insert into products (id, product, department) values (77, 'Goulash Seasoning', 'Grocery');
insert into products (id, product, department) values (78, 'Juice - Apple, 1.36l', 'Beverages');
insert into products (id, product, department) values (79, 'Cake - Cake Sheet Macaroon', 'Bakery');
insert into products (id, product, department) values (80, 'Bread - White Epi Baguette', 'Bakery');
insert into products (id, product, department) values (81, 'Food Colouring - Green', 'Grocery');
insert into products (id, product, department) values (82, 'Bread Base - Gold Formel', 'Grocery');
insert into products (id, product, department) values (83, 'Cabbage - Red', 'Fruit & Veg');
insert into products (id, product, department) values (84, 'Soup - Cream Of Broccoli, Dry', 'Grocery');
insert into products (id, product, department) values (85, 'Wine - White, Antinore Orvieto', 'Alcohol');
insert into products (id, product, department) values (86, 'Egg - Salad Premix', 'Grocery');
insert into products (id, product, department) values (87, 'Vaccum Bag 10x13', 'Misc');
insert into products (id, product, department) values (88, 'Beans - Green', 'Fruit & Veg');
insert into products (id, product, department) values (89, 'Coffee Guatemala Dark', 'Grocery');
insert into products (id, product, department) values (90, 'Wine - Rioja Campo Viejo', 'Alcohol');
insert into products (id, product, department) values (91, 'Chocolate - Dark Callets', 'Confectionery');
insert into products (id, product, department) values (92, 'Grand Marnier', 'Alcohol');
insert into products (id, product, department) values (93, 'Pear - Prickly', 'Fruit & Veg');
insert into products (id, product, department) values (94, 'Sproutsmustard Cress', 'Fruit & Veg');
insert into products (id, product, department) values (95, 'Gingerale - Schweppes, 355 Ml', 'Beverages');
insert into products (id, product, department) values (96, 'Corn - On The Cob', 'Fruit & Veg');
insert into products (id, product, department) values (97, 'Plums - Red', 'Fruit & Veg');
insert into products (id, product, department) values (98, 'Cheese - Brie,danish', 'Dairy');
insert into products (id, product, department) values (99, 'Schnappes Peppermint - Walker', 'Alcohol');
insert into products (id, product, department) values (100, 'Ecolab Silver Fusion', 'Cleaning Products');
insert into products (id, product, department) values (101, 'Cat Food', 'Pet Products')
insert into products (id, product, department) values (102, 'Tylenol', 'Pharmacy')

SET IDENTITY_INSERT products off;
GO

create table product_shopping_list (
	listId int NOT NULL,
	productId INT NOT NULL,
	quantity int DEFAULT 1,

	CONSTRAINT pk_product_shopping_list_listId_productId PRIMARY KEY (listId, productId),
	CONSTRAINT fk_product_shopping_list_products FOREIGN KEY (productId) REFERENCES products(id),

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

set identity_insert shopping_list on;
go

insert into shopping_list (ListId, ListDate, ListName) values (1, '2018/06/15', 'Ali First List');

set identity_insert shopping_list off;

set identity_insert product_shopping_list on;
go

INSERT INTO product_shopping_list (listId, productId, quantity) VALUES (13, 92, 1)

insert into product_shopping_list (listId, productId, quantity)
values (1, 92, 1), (1, 45, 2);

set identity_insert product_shopping_list off;
