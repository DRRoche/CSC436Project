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
value( 110895339, 10, 'Marketside Roasted Red Pepper Hummus', 10, 'oz', 2.67);

-- (int, int, varchar, varchar, varchar, int)
insert into store(store_ID, street_num, street_name, city, state, zip_code)
value();

-- (char, varchar, bool)
insert into brand(brand_ID, brand_name, chain_exclusive)
value();

-- (int, int, varchar, enum, enum, numeric)
insert into employee(E_ID, M_ID, e_name, position, payroll_type, pay_rate)
value();

-- (int, int)
insert into store_departments(store_ID, dept_ID)
value();

-- (int, int)
insert into stocks(store_ID, SKU)
value();

-- (char, int)
insert into manufactures(brand_ID, SKU)
value();

-- (int, int)
insert into works_in(dept_ID, E_ID)
value();