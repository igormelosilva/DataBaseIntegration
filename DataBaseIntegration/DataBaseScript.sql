CREATE TABLE IF NOT EXISTS products(
	id SERIAL PRIMARY KEY,
	name VARCHAR(50),
	model VARCHAR(50),
	quantity INTEGER,
	value REAL

);