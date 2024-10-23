-- Insert initial data for walmart product management DB

-- (int, varchar)
insert into department(dept_ID, dept_name)
value(1, 'Pantry'),
(2, 'Breakfast & Cereal'),
(3, 'Beverages'),
(4, 'Frozen'),
(5, 'Snacks'),
(6, 'Meat & Seafood'),
(7, 'Candy'),
(8, 'Dairy & Eggs'),
(9, 'Bakery & bread'),
(10, 'Deli'),
(11, 'Coffee'),
(12, 'Baking'),
(13, 'Fresh Produce'),
(14, 'Alchohol');

-- (int, char, varchar, int, enum, numeric)
insert into product(SKU, dept_ID, prod_name, size, unit, price)
value( 110895339, 10, 'Marketside Roasted Red Pepper Hummus', 10, 'oz', 2.67),
( 105455228, 10, 'Marketside Roasted Garlic Hummus', 10, 'oz', 2.67),
( 128642379, 10, 'Marketside Classic Hummus', 10, 'oz', 2.67),
( 366126367, 10, 'Marketside Everything Hummus', 10, 'oz', 2.67),
( 160090316, 10, "Price's Jalapeno Dip", 12, 'oz', 3.12),
( 174071300, 10, "Price's Green Chili Dip", 12, 'oz', 3.12),
( 10294995, 10, "Dean's, French Onion Dip", 16, 'oz', 2.42),
( 37915367, 10, "Marketside Spinach & Artichoke Dip", 16, 'oz', 5.54),
( 482903957, 10, "Fresh Cravings Roasted Red Pepper Hummus", 10, 'oz', 3.27),
( 538183292, 10, "Marketside Buffalo Style Chicken Dip", 11, 'oz', 4.54),
( 628355959, 10, "Marketside Spicy Hummus", 10, 'oz', 2.67),
( 764726416, 10, "Marketside Pine Nut Hummus", 10, 'oz', 2.67),
( 439259695, 10, "Marketside Cantina Style Salsa", 16, 'oz', 2.86),
( 825414671, 10, "Fresh Cravings Everything Bagel Hummus", 10, 'oz', 3.27),
( 437850228, 10, "Fresh Cravings Roasted Garlic Hummus", 10, 'oz', 3.27);

-- (int, int, varchar(30), varchar(30), varchar(30), int)
INSERT INTO store (store_ID, street_num, street_name, city, state, zip_code)
VALUES (1, 100, 'Main St', 'Providence', 'RI', 02903),
(2, 250, 'Elm St', 'Warwick', 'RI', 02886),
(3, 450, 'Maple Ave', 'Cranston', 'RI', 02920),
(4, 75, 'Chestnut St', 'Boston', 'MA', 02108),
(5, 555, 'Commonwealth Ave', 'Cambridge', 'MA', 02139),
(6, 1200, 'Market St', 'Philadelphia', 'PA', 19107),
(7, 678, 'Broad St', 'Pittsburgh', 'PA', 15222),
(8, 101, 'Liberty St', 'Newport', 'RI', 02840),
(9, 89, 'Beacon St', 'Newton', 'MA', 02458),
(10, 300, 'Walnut St', 'Harrisburg', 'PA', 17101);

-- (char(5), varchar(20), bool)
insert into brand(brand_ID, brand_name, chain_exclusive)
value("MARKT", "Marketside", true),
("PRICE", "Price's Dairy", false),
("DEANS", "Dean's", false),
("FRESH", "Fresh Cravings", false);

-- (int, int, varchar, enum('Manager', 'Cashier', 'Stocker'), enum('Hourly', 'Salary'), numeric)
insert into employee(E_ID, M_ID, e_name, position, payroll_type, pay_rate)
value(1, null, "Bob Boberts", "Manager", "Salary", 65000.00);

-- (int, int)
insert into store_departments(store_ID, dept_ID)
value(1, 10),
(2, 10),
(3, 10),
(4, 10),
(5, 10),
(6, 10),
(7, 10),
(8, 10),
(9, 10),
(10, 10);

-- (int, int)
insert into stocks(store_ID, SKU)
value(1, 110895339),(1, 105455228),(1, 128642379),(1, 366126367),(1, 160090316),(1, 174071300),(1, 10294995),(1, 37915367),(1, 482903957),(1, 538183292),(1, 628355959),(1, 764726416),(1, 439259695),(1, 825414671),(1, 437850228),
(2, 110895339),(2, 105455228),(2, 128642379),(2, 366126367),(2, 160090316),(2, 174071300),(2, 10294995),(2, 37915367),(2, 482903957),(2, 538183292),(2, 628355959),(2, 764726416),(2, 439259695),(2, 825414671),(2, 437850228),
(3, 110895339),(3, 105455228),(3, 128642379),(3, 366126367),(3, 160090316),(3, 174071300),(3, 10294995),(3, 37915367),(3, 482903957),(3, 538183292),(3, 628355959),(3, 764726416),(3, 439259695),(3, 825414671),(3, 437850228),
(4, 110895339),(4, 105455228),(4, 128642379),(4, 366126367),(4, 160090316),(4, 174071300),(4, 10294995),(4, 37915367),(4, 482903957),(4, 538183292),(4, 628355959),(4, 764726416),(4, 439259695),(4, 825414671),(4, 437850228),
(5, 110895339),(5, 105455228),(5, 128642379),(5, 366126367),(5, 160090316),(5, 174071300),(5, 10294995),(5, 37915367),(5, 482903957),(5, 538183292),(5, 628355959),(5, 764726416),(5, 439259695),(5, 825414671),(5, 437850228),
(6, 110895339),(6, 105455228),(6, 128642379),(6, 366126367),(6, 160090316),(6, 174071300),(6, 10294995),(6, 37915367),(6, 482903957),(6, 538183292),(6, 628355959),(6, 764726416),(6, 439259695),(6, 825414671),(6, 437850228),
(7, 110895339),(7, 105455228),(7, 128642379),(7, 366126367),(7, 160090316),(7, 174071300),(7, 10294995),(7, 37915367),(7, 482903957),(7, 538183292),(7, 628355959),(7, 764726416),(7, 439259695),(7, 825414671),(7, 437850228),
(8, 110895339),(8, 105455228),(8, 128642379),(8, 366126367),(8, 160090316),(8, 174071300),(8, 10294995),(8, 37915367),(8, 482903957),(8, 538183292),(8, 628355959),(8, 764726416),(8, 439259695),(8, 825414671),(8, 437850228),
(9, 110895339),(9, 105455228),(9, 128642379),(9, 366126367),(9, 160090316),(9, 174071300),(9, 10294995),(9, 37915367),(9, 482903957),(9, 538183292),(9, 628355959),(9, 764726416),(9, 439259695),(9, 825414671),(9, 437850228),
(10, 110895339),(10, 105455228),(10, 128642379),(10, 366126367),(10, 160090316),(10, 174071300),(10, 10294995),(10, 37915367),(10, 482903957),(10, 538183292),(10, 628355959),(10, 764726416),(10, 439259695),(10, 825414671),(10, 437850228);


-- (char(5), int)
insert into manufactures(brand_ID, SKU)
value("MARKT", 110895339),
("MARKT", 105455228),
("MARKT", 128642379),
("MARKT", 366126367),
("PRICE", 160090316),
("PRICE", 174071300),
("DEANS", 10294995),
("MARKT", 37915367),
("FRESH", 482903957),
("MARKT", 538183292),
("MARKT", 628355959),
("MARKT", 764726416),
("MARKT", 439259695),
("FRESH", 825414671),
("FRESH", 437850228);


-- (int, int)
insert into works_in(dept_ID, E_ID)
value(10, 1);