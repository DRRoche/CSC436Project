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
(14, 'Alchohol'),
(15, 'General')
-- -----------------------------------------------------------------
;

-- (int, char, varchar, int, enum('oz', 'ml', 'lt', 'lb', 'pcs'), numeric)
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
( 437850228, 10, "Fresh Cravings Roasted Garlic Hummus", 10, 'oz', 3.27),
(8467275, 11, "Melitta Coffee Filter 200 Pack", 200, 'pcs',	2.17),
(196052148,	11, "Great Value #4 Cone Coffee Filters 100 count", 100, 'pcs', 2.28),
(21686016, 11, "Melitta #4 Natural Brown Cone Coffee Filters 100 Ct", 100, 'pcs', 3.62),
(879555, 11, "Brew Rite Paper Coffee Filter (200 Pack)", 200, 'pcs', 1.88),
(132074177, 11, "Great Value Basket Coffee Filters, 1-4 Cup 200 Count", 200, 'pcs', 1.48),
(114669629, 11, "Great Value Natural Basket Coffee Filters 100 count", 100, 'pcs', 1.48),
(2304246, 11, "BUNN 8-12 Cup Premium Home Flat-Bottom Coffee Paper Filters", 100, 'pcs', 1.96),
(129570465, 11, "Great Value #2 Cone Coffee Filters 100 count", 100, 'pcs', 2.28),
(469192827, 11, "Perfect Pod Single Serve Paper Filters 100 Count Pack of Paper Filters w No Lid", 100, 'pcs', 8.98),
(882653, 11, "Brew Rite Basket Coffee Filter 200 Pack", 100, 'pcs', 1.88),
(14968036, 11, "Brew Rite #4 Cone White Coffee Filters, 100 Count", 100, 'pcs', 3.78),
(38470909, 11, "KRUPS Fast Touch Electric Coffee and Spice Grinder With Stainless Steel Blades, Black", 1, 'pcs', 18.88),
(749459541, 11, "Bodum Pour Over Coffee Dripper 34 Ounce with Reusable Stainless Steel Filter, Cork", 1, 'pcs', 19.21),
(20576244, 11, "Brew Rite Synthetic Coffee Filter (100 Pack)", 100, 'pcs', 1.24),
(104785770, 11, "Brew Rite 8 to 12-Cup Permanent Basket Filter", 1, 'pcs', 6.94),
(486280096, 12, "Cobram Estate California Select Extra Virgin Olive Oil 375ml",	375, 'ml', 10.13),
(436351654, 12, "Terra Verde, Garlic& Basil Pasta Oil, 250ml", 250, 'ml', 6.40),
(816513671, 12, "California Olive Ranch Avocado Blend Extra Virgin Olive Oil, 25.4 fl oz", 25.4, 'oz', 14.24),
(50838412, 12, "Bari Extra Virgin California Organic Olive Oil, 500 ml", 500, 'ml',	10.68),
(22234389, 12, "Star Extra Virgin Olive Oil Value Pack, 1.5 Liter",	1.5, 'lt',	14.74),
(10533368, 12, "Star Fine Foods Star Special Reserve Olive Oil, 17 oz",	17, 'oz', 8.38),
(891026537, 12, "Candy & Baking Flavoring .125Oz 3/Pkg-Summer Fruit-Blueberry/Raspberry/Pineapl", 0.125, 'oz', 3.78),
(13908629, 12, "Star Fine Foods Star Olive Oil, 16.9 oz", 16.9, 'oz',	6.62),
(55504275, 12, "Family Foods Family Sesame Oil, 6 oz", 6, 'oz', 2.82),
(151201587, 12, "Momoya Karasode Karakunai Layu 3.87 oz (110 g)", 3.87, 'oz', 5.48)
-- ------------------------------------------------------------------------
;

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
(10, 300, 'Walnut St', 'Harrisburg', 'PA', 17101)
-- --------------------------------------------------------
;

-- (char(5), varchar(20), bool)
insert into brand(brand_ID, brand_name, chain_exclusive)
value("MARKT", "Marketside", true),
("PRICE", "Price's Dairy", false),
("DEANS", "Dean's", false),
("FRESH", "Fresh Cravings", false),
("MELIT", "Melitta", false),
("GTVAL", "Great Value", true),
("BRWRT", "Brew Rite", false),
("BUNN", "BUNN", false),
("PRPOD", "Perfect POD", false),
("KRUPS", "KRUPS", false),
("BODUM", "BODUM", false),
("COBRM", "Cobram Estate", false),
("TERRA", "Terra Verda", false),
("CALOR", "California Olive Ranch", false),
("BARI", "Bari", false),
("STAR", "STAR", false),
("LORAN", "LorAnn Oils", false),
("FAMLY", "Family Foods", false),
("MOMOY", "Momoya", false)
-- -----------------------------------------------------------
;

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
(10, 10)
-- -------------------------------------------------
;

INSERT INTO stocks(store_ID, SKU)
VALUES
-- Store 1
(1, 110895339),(1, 105455228),(1, 128642379),(1, 366126367),(1, 160090316),(1, 174071300),(1, 10294995),(1, 37915367),(1, 482903957),(1, 538183292),
(1, 628355959),(1, 764726416),(1, 437850228),(1, 8467275),(1, 196052148),(1, 21686016),(1, 879555),(1, 132074177),(1, 114669629),(1, 14968036),

-- Store 2
(2, 110895339),(2, 128642379),(2, 366126367),(2, 160090316),(2, 174071300),(2, 10294995),(2, 37915367),(2, 538183292),(2, 628355959),(2, 825414671),
(2, 437850228),(2, 8467275),(2, 196052148),(2, 21686016),(2, 132074177),(2, 114669629),(2, 2304246),(2, 129570465),(2, 882653),(2, 14968036),

-- Store 3
(3, 110895339),(3, 105455228),(3, 366126367),(3, 160090316),(3, 174071300),(3, 37915367),(3, 538183292),(3, 628355959),(3, 764726416),(3, 437850228),
(3, 8467275),(3, 196052148),(3, 879555),(3, 132074177),(3, 2304246),(3, 129570465),(3, 882653),(3, 14968036),(3, 38470909),(3, 104785770),

-- Store 4
(4, 110895339),(4, 105455228),(4, 128642379),(4, 366126367),(4, 174071300),(4, 10294995),(4, 538183292),(4, 764726416),(4, 437850228),(4, 196052148),
(4, 21686016),(4, 132074177),(4, 114669629),(4, 2304246),(4, 882653),(4, 14968036),(4, 38470909),(4, 749459541),(4, 20576244),(4, 486280096),

-- Store 5
(5, 110895339),(5, 128642379),(5, 366126367),(5, 160090316),(5, 10294995),(5, 628355959),(5, 825414671),(5, 437850228),(5, 8467275),(5, 21686016),
(5, 879555),(5, 132074177),(5, 114669629),(5, 14968036),(5, 38470909),(5, 104785770),(5, 486280096),(5, 816513671),(5, 22234389),(5, 10533368),

-- Store 6
(6, 110895339),(6, 105455228),(6, 160090316),(6, 174071300),(6, 37915367),(6, 764726416),(6, 437850228),(6, 196052148),(6, 21686016),(6, 114669629),
(6, 2304246),(6, 469192827),(6, 882653),(6, 38470909),(6, 749459541),(6, 20576244),(6, 104785770),(6, 486280096),(6, 436351654),(6, 50838412),

-- Store 7
(7, 110895339),(7, 128642379),(7, 160090316),(7, 10294995),(7, 37915367),(7, 482903957),(7, 538183292),(7, 764726416),(7, 439259695),(7, 437850228),
(7, 8467275),(7, 132074177),(7, 2304246),(7, 129570465),(7, 882653),(7, 14968036),(7, 38470909),(7, 749459541),(7, 20576244),(7, 486280096),

-- Store 8
(8, 110895339),(8, 105455228),(8, 128642379),(8, 174071300),(8, 37915367),(8, 482903957),(8, 764726416),(8, 437850228),(8, 8467275),(8, 196052148),
(8, 879555),(8, 132074177),(8, 114669629),(8, 2304246),(8, 129570465),(8, 882653),(8, 38470909),(8, 749459541),(8, 20576244),(8, 104785770),

-- Store 9
(9, 110895339),(9, 366126367),(9, 160090316),(9, 174071300),(9, 10294995),(9, 482903957),(9, 628355959),(9, 764726416),(9, 439259695),(9, 825414671),
(9, 437850228),(9, 8467275),(9, 21686016),(9, 132074177),(9, 114669629),(9, 882653),(9, 38470909),(9, 104785770),(9, 436351654),(9, 22234389),

-- Store 10
(10, 110895339),(10, 105455228),(10, 366126367),(10, 160090316),(10, 174071300),(10, 10294995),(10, 37915367),(10, 538183292),(10, 437850228),(10, 8467275),
(10, 196052148),(10, 21686016),(10, 879555),(10, 132074177),(10, 2304246),(10, 882653),(10, 14968036),(10, 38470909),(10, 486280096),(10, 50838412);

-- (char(5), int)
insert into manufactures(brand_ID, SKU)
value("MARKT", 110895339),
("MARKT", 105455228),("MARKT", 128642379),("MARKT", 366126367),("PRICE", 160090316),("PRICE", 174071300),("DEANS", 10294995),("MARKT", 37915367),("FRESH", 482903957),
("MARKT", 538183292),("MARKT", 628355959),("MARKT", 764726416),("MARKT", 439259695),("FRESH", 825414671),("FRESH", 437850228),("MELIT",8467275),("GTVAL",196052148),
("MELIT",21686016),("BRWRT",879555),("GTVAL",132074177),("GTVAL",114669629),("BUNN",2304246),("GTVAL",129570465),("PRPOD",469192827),("BRWRT",882653),("BRWRT",14968036),
("KRUPS",38470909),("BODUM",749459541),("BRWRT",20576244),("BRWRT",104785770),("COBRM", 486280096),("TERRA", 436351654),("CALOR", 816513671),("BARI", 50838412),
("STAR", 22234389),("STAR", 10533368),("LORAN", 891026537),("STAR", 13908629),("FAMLY", 55504275),("MOMOY", 151201587)
-- -------------------------------------------------------------
;

-- (int, int, varchar, enum('Store Manager', 'Assistant Manager', 'Dept Manager', 'Cashier', 'Stocker'), enum('Hourly', 'Salary'), numeric)
INSERT INTO employee(E_ID, M_ID, e_name, position, payroll_type, pay_rate) VALUES
-- store 1
(1, NULL, "Bob Boberts", "Store Manager", "Salary", 85000.00),
(2, 1, "Jane Smith", "Assistant Manager", "Salary", 70000.00),
(3, 2, "Mike Johnson", "Dept Manager", "Salary", 65000.00),
(4, 2, "Sue Lee", "Dept Manager", "Salary", 64000.00),
(5, 2, "Jake Brown", "Dept Manager", "Salary", 63000.00),
(6, 2, "Lisa White", "Dept Manager", "Salary", 65000.00),
(7, 2, "Paul Black", "Dept Manager", "Salary", 62000.00),
(8, 2, "Rachel Green", "Dept Manager", "Salary", 66000.00),
(9, 2, "Tom Gray", "Dept Manager", "Salary", 67000.00),
(10, 2, "Nina Purple", "Dept Manager", "Salary", 63000.00),
(11, 2, "Rob Pink", "Dept Manager", "Salary", 62000.00),
(12, 2, "Sam Blue", "Dept Manager", "Salary", 64000.00),
(13, 2, "Beth Silver", "Dept Manager", "Salary", 66000.00),
(14, 2, "Ed Brown", "Dept Manager", "Salary", 62000.00),
(15, 2, "Tina Yellow", "Dept Manager", "Salary", 65000.00),
(16, 2, "Carl White", "Dept Manager", "Salary", 64000.00),
(17, 2, "Ellen Gray", "Cashier", "Hourly", 14.00),
(18, 3, "Kyle Black", "Stocker", "Hourly", 14.50),
(19, 3, "Mia Orange", "Stocker", "Hourly", 13.50),
(20, 4, "Leo Red", "Stocker", "Hourly", 14.00),
(21, 4, "Eve Green", "Stocker", "Hourly", 13.75),
(22, 5, "Sam Brown", "Stocker", "Hourly", 13.50),
(23, 5, "Lily White", "Stocker", "Hourly", 13.25),
(24, 6, "Greg Silver", "Stocker", "Hourly", 14.00),
(25, 6, "Holly Pink", "Stocker", "Hourly", 13.80),
(26, 7, "Jake Blue", "Stocker", "Hourly", 14.25),
(27, 7, "Emma Yellow", "Stocker", "Hourly", 13.60),
(28, 8, "Ian Purple", "Stocker", "Hourly", 13.90),
(29, 8, "Sophie Brown", "Stocker", "Hourly", 14.10),
(30, 9, "Liam Orange", "Stocker", "Hourly", 13.70),
(31, 9, "Megan Black", "Stocker", "Hourly", 14.00),
(32, 10, "Brian Red", "Stocker", "Hourly", 13.50),
(33, 10, "Anna Green", "Stocker", "Hourly", 14.00),
(34, 11, "Chris Blue", "Stocker", "Hourly", 13.60),
(35, 11, "Julie Brown", "Stocker", "Hourly", 13.80),
(36, 12, "Pat White", "Stocker", "Hourly", 13.50),
(37, 12, "Zoe Green", "Stocker", "Hourly", 14.20),
(38, 13, "Oscar Black", "Stocker", "Hourly", 13.90),
(39, 13, "Vera Yellow", "Stocker", "Hourly", 13.50),
(40, 14, "Sam Pink", "Stocker", "Hourly", 14.30),
(41, 14, "Tina Gray", "Stocker", "Hourly", 13.60),
(42, 2, "Linda Red", "Cashier", "Hourly", 15.00),
(43, 2, "Gary Green", "Cashier", "Hourly", 14.50),
(44, 2, "Betty Black", "Cashier", "Hourly", 14.80),
(45, 2, "Nancy White", "Cashier", "Hourly", 15.20),
(46, 2, "Frank Yellow", "Cashier", "Hourly", 14.90),
-- store 2
(47, NULL, "Henry Adams", "Store Manager", "Salary", 85000.00),
(48, 47, "Samantha Lee", "Assistant Manager", "Salary", 70000.00),
(49, 48, "Peter Jones", "Dept Manager", "Salary", 65000.00),
(50, 48, "Cathy Lane", "Dept Manager", "Salary", 64000.00),
(51, 48, "Dan Green", "Dept Manager", "Salary", 63000.00),
(52, 48, "Molly White", "Dept Manager", "Salary", 65000.00),
(53, 48, "Rob Black", "Dept Manager", "Salary", 62000.00),
(54, 48, "Nina Orange", "Dept Manager", "Salary", 66000.00),
(55, 48, "Tom Silver", "Dept Manager", "Salary", 67000.00),
(56, 48, "Ella Brown", "Dept Manager", "Salary", 63000.00),
(57, 48, "Sam Pink", "Dept Manager", "Salary", 62000.00),
(58, 48, "Luke Blue", "Dept Manager", "Salary", 64000.00),
(59, 48, "Janet Silver", "Dept Manager", "Salary", 66000.00),
(60, 48, "Ed Gray", "Dept Manager", "Salary", 62000.00),
(61, 48, "Tara White", "Dept Manager", "Salary", 65000.00),
(62, 48, "Carl Gold", "Dept Manager", "Salary", 64000.00),
(63, 62, "Eve Red", "Stocker", "Hourly", 15.00),
(64, 49, "Sean Orange", "Stocker", "Hourly", 14.50),
(65, 49, "Grace Black", "Stocker", "Hourly", 13.50),
(66, 50, "Owen Blue", "Stocker", "Hourly", 14.00),
(67, 50, "Alice Green", "Stocker", "Hourly", 13.75),
(68, 51, "Max Silver", "Stocker", "Hourly", 13.50),
(69, 51, "Lana Red", "Stocker", "Hourly", 13.25),
(70, 52, "Joe Pink", "Stocker", "Hourly", 14.00),
(71, 52, "Hannah Brown", "Stocker", "Hourly", 13.80),
(72, 53, "Dean Yellow", "Stocker", "Hourly", 14.25),
(73, 53, "Ava Gray", "Stocker", "Hourly", 13.60),
(74, 54, "Ivan Orange", "Stocker", "Hourly", 13.90),
(75, 54, "Nora Blue", "Stocker", "Hourly", 14.10),
(76, 55, "Will Brown", "Stocker", "Hourly", 13.70),
(77, 55, "Eva Pink", "Stocker", "Hourly", 14.00),
(78, 56, "Ian Green", "Stocker", "Hourly", 13.50),
(79, 56, "Amy Silver", "Stocker", "Hourly", 14.00),
(80, 57, "Kyle Red", "Stocker", "Hourly", 13.60),
(81, 57, "Judy Black", "Stocker", "Hourly", 13.80),
(82, 58, "Hugo Gray", "Stocker", "Hourly", 13.50),
(83, 58, "Zara White", "Stocker", "Hourly", 14.20),
(84, 59, "Ray Yellow", "Stocker", "Hourly", 13.90),
(85, 59, "Val Green", "Stocker", "Hourly", 13.50),
(86, 60, "Kim Silver", "Stocker", "Hourly", 14.30),
(87, 60, "Pat Blue", "Stocker", "Hourly", 13.60),
(88, 48, "Rita Orange", "Cashier", "Hourly", 15.00),
(89, 48, "George Brown", "Cashier", "Hourly", 14.50),
(90, 48, "Lori White", "Cashier", "Hourly", 14.80),
(91, 48, "Duke Gray", "Cashier", "Hourly", 15.20),
(92, 48, "Tess Red", "Cashier", "Hourly", 14.90),
-- Store 3
(93, NULL, "Olivia Brown", "Store Manager", "Salary", 85000.00),
(94, 93, "Michael Johnson", "Assistant Manager", "Salary", 70000.00),
(95, 94, "Elena Clarke", "Dept Manager", "Salary", 65000.00),
(96, 94, "David Garcia", "Dept Manager", "Salary", 64000.00),
(97, 94, "Sophia Lee", "Dept Manager", "Salary", 63000.00),
(98, 94, "James Wilson", "Dept Manager", "Salary", 65000.00),
(99, 94, "Linda Martinez", "Dept Manager", "Salary", 62000.00),
(100, 94, "Brian Lopez", "Dept Manager", "Salary", 66000.00),
(101, 94, "Ella Walker", "Dept Manager", "Salary", 67000.00),
(102, 94, "Sammy Thomas", "Dept Manager", "Salary", 63000.00),
(103, 94, "Helen Harris", "Dept Manager", "Salary", 62000.00),
(104, 94, "Liam King", "Dept Manager", "Salary", 64000.00),
(105, 94, "Isaac Wright", "Dept Manager", "Salary", 66000.00),
(106, 94, "Tina Young", "Dept Manager", "Salary", 62000.00),
(107, 94, "Chris Hill", "Dept Manager", "Salary", 65000.00),
(108, 94, "Zoe Scott", "Dept Manager", "Salary", 64000.00),
(109, 107, "Emma Evans", "Stocker", "Hourly", 16.00),
(110, 95, "Oscar Allen", "Stocker", "Hourly", 14.50),
(111, 95, "Eva Baker", "Stocker", "Hourly", 13.50),
(112, 96, "Jake Perry", "Stocker", "Hourly", 14.00),
(113, 96, "Grace Adams", "Stocker", "Hourly", 13.75),
(114, 97, "Mark Perez", "Stocker", "Hourly", 13.50),
(115, 97, "Lucy Brooks", "Stocker", "Hourly", 13.25),
(116, 98, "Matt Flores", "Stocker", "Hourly", 14.00),
(117, 98, "Isla Morris", "Stocker", "Hourly", 13.80),
(118, 99, "Eric Reed", "Stocker", "Hourly", 14.25),
(119, 99, "Ava Bell", "Stocker", "Hourly", 13.60),
(120, 100, "Leo Nelson", "Stocker", "Hourly", 13.90),
(121, 100, "Ella Price", "Stocker", "Hourly", 14.10),
(122, 101, "Anna Diaz", "Stocker", "Hourly", 13.70),
(123, 101, "Alex Griffin", "Stocker", "Hourly", 14.00),
(124, 102, "Owen Stone", "Stocker", "Hourly", 13.50),
(125, 102, "Lily Gray", "Stocker", "Hourly", 14.00),
(126, 103, "Nina Shaw", "Stocker", "Hourly", 13.60),
(127, 103, "Ryan Murray", "Stocker", "Hourly", 13.80),
(128, 104, "Elise Webb", "Stocker", "Hourly", 13.50),
(129, 104, "Ian Cooper", "Stocker", "Hourly", 14.20),
(130, 105, "Kayla Hughes", "Stocker", "Hourly", 13.90),
(131, 105, "Sam Butler", "Stocker", "Hourly", 13.50),
(132, 106, "Gina Morgan", "Stocker", "Hourly", 14.30),
(133, 106, "Tim Ward", "Stocker", "Hourly", 13.60),
(134, 94, "Rose Carter", "Cashier", "Hourly", 15.00),
(135, 94, "Ben Turner", "Cashier", "Hourly", 14.50),
(136, 94, "Tina Russell", "Cashier", "Hourly", 14.80),
(137, 94, "Gary White", "Cashier", "Hourly", 15.20),
(138, 94, "Joan Perry", "Cashier", "Hourly", 14.90);

-- Assign each employee to a department and store
INSERT INTO works_in(dept_ID, E_ID, store_ID) VALUES
-- store 1
(15, 1, 1),  (15, 2, 1),  
(1, 3, 1),   (2, 4, 1),   (3, 5, 1),   (4, 6, 1),   (5, 7, 1),
(6, 8, 1),   (7, 9, 1),   (8, 10, 1),  (9, 11, 1),  (10, 12, 1),
(11, 13, 1), (12, 14, 1), (13, 15, 1), (14, 16, 1), (15, 17, 1),
(1, 18, 1),  (1, 19, 1),  (2, 20, 1),  (2, 21, 1),  (3, 22, 1),
(3, 23, 1),  (4, 24, 1),  (4, 25, 1),  (5, 26, 1),  (5, 27, 1),
(6, 28, 1),  (6, 29, 1),  (7, 30, 1),  (7, 31, 1),  (8, 32, 1),
(8, 33, 1),  (9, 34, 1),  (9, 35, 1),  (10, 36, 1), (10, 37, 1),
(11, 38, 1), (11, 39, 1), (12, 40, 1), (12, 41, 1), (15, 42, 1),
(15, 43, 1), (15, 44, 1), (15, 45, 1), (15, 46, 1),
-- store 2
(15, 47, 2),  (15, 48, 2),
(1, 49, 2),   (2, 50, 2),   (3, 51, 2),   (4, 52, 2),   (5, 53, 2),
(6, 54, 2),   (7, 55, 2),   (8, 56, 2),   (9, 57, 2),   (10, 58, 2),
(11, 59, 2),  (12, 60, 2),  (13, 61, 2),  (14, 62, 2),  (14, 63, 2),
(1, 64, 2),   (1, 65, 2),   (2, 66, 2),   (2, 67, 2),   (3, 68, 2),
(3, 69, 2),   (4, 70, 2),   (4, 71, 2),   (5, 72, 2),   (5, 73, 2),
(6, 74, 2),   (6, 75, 2),   (7, 76, 2),   (7, 77, 2),   (8, 78, 2),
(8, 79, 2),   (9, 80, 2),   (9, 81, 2),   (10, 82, 2),  (10, 83, 2),
(11, 84, 2),  (11, 85, 2),  (12, 86, 2),  (12, 87, 2),  (15, 88, 2),
(15, 89, 2),  (15, 90, 2),  (15, 91, 2),  (15, 92, 2),
-- store 3
(15, 93, 3),  (15, 94, 3),
(1, 95, 3),   (2, 96, 3),   (3, 97, 3),   (4, 98, 3),   (5, 99, 3),
(6, 100, 3),  (7, 101, 3),  (8, 102, 3),  (9, 103, 3),  (10, 104, 3),
(11, 105, 3), (12, 106, 3), (13, 107, 3), (14, 108, 3), (13, 109, 3),
(1, 110, 3),  (1, 111, 3),  (2, 112, 3),  (2, 113, 3),  (3, 114, 3),
(3, 115, 3),  (4, 116, 3),  (4, 117, 3),  (5, 118, 3),  (5, 119, 3),
(6, 120, 3),  (6, 121, 3),  (7, 122, 3),  (7, 123, 3),  (8, 124, 3),
(8, 125, 3),  (9, 126, 3),  (9, 127, 3),  (10, 128, 3), (10, 129, 3),
(11, 130, 3), (11, 131, 3), (12, 132, 3), (12, 133, 3), (15, 134, 3),
(15, 135, 3), (15, 136, 3), (15, 137, 3), (15, 138, 3);
