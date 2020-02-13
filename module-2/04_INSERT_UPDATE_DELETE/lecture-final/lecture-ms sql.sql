use [World] 
-- INSERT

-- 1. Add Klingon as a spoken language in the USA

INSERT INTO countrylanguage (countrycode, language, isofficial, percentage)
VALUES ('USA', 'Klingon', 1, 2.04)

SELECT *
FROM countrylanguage
WHERE language = 'klingon';

-- 2. Add Klingon as a spoken language in Great Britain


INSERT INTO countrylanguage (countrycode, language, isofficial, percentage)
VALUES ((SELECT code FROM country WHERE name = 'ZZZ'), 'Klingon', 0 ,15.89)
SELECT code FROM country WHERE name = 'ZZZ'
SELECT *
FROM countrylanguage
WHERE language = 'klingon';



-- UPDATE

-- 1. Update the capital of the USA to Houston
UPDATE country
SET capital = 3796 
WHERE code = 'USA'

SELECT * FROM country where code= 'usa'

-- 2. Update the capital of the USA to Washington DC and the head of state

UPDATE country
	SET 
		capital = (SELECT id from city WHERE name = 'washington'),
		headofstate = 'Joe Riggs'
	WHERE code = 'USA'

SELECT * from country where headofstate = 'joe'
SELECT  * from city where id = 3813
	SELECT id from city WHERE name = 'washington'
-- DELETE

-- 1. Delete English as a spoken language in the USA
--DELETE FROM countrylanguage
--where language = 'english' AND countrycode = 'USA'

SELECT * from countrylanguage where language = 'english' AND countrycode = 'USA'

-- 2. Delete all occurrences of the Klingon language 

--DELETE from countrylanguage 
SELECT * from countrylanguage where language = 'klingon'

--DELETE FROM countrylanguage 
--WHERE language='klingon'
-- REFERENTIAL INTEGRITY

-- 1. Try just adding Elvish to the country language table.

INSERT INTO countrylanguage	(countrycode)
	VALUES('elv');
 

-- 2. Try inserting English as a spoken language in the country ZZZ. What happens?

INSERT INTO countrylanguage (countrycode, language, isofficial, percentage)
VALUES ('ZZZ', 'English', 1, 65)

select * from country where code = 'zzz'

-- 3. Try deleting the country USA. What happens?
use [World] 
DELETE FROM country where code = 'USA'
SELECT * from country where code = 'USA'

-- CONSTRAINTS

-- 1. Try inserting English as a spoken language in the USA

SELECT * FROM countrylanguage where countrycode='USA'

INSERT INTO countrylanguage (countrycode, language, isofficial, percentage)
VALUES ('USA', 'English', 0, 86.2)

-- 2. Try again. What happens?
INSERT INTO countrylanguage (countrycode, language, isofficial, percentage)
VALUES ('USA', 'English', 0, 86.2)

-- 3. Let's relocate the USA to the continent - 'Outer Space'

UPDATE country 
SET continent = 'Outer Space'
WHERE code = 'USA'


-- How to view all of the constraints

SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
SELECT * FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE
SELECT * FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS


-- TRANSACTIONS

-- 1. Try deleting all of the rows from the country language table and roll it back.

BEGIN TRANSACTION

	SELECT * FROM countrylanguage
	DELETE FROM countrylanguage
	SELECT * FROM countrylanguage

ROLLBACK TRANSACTION

SELECT * from countrylanguage

--COMMIT

-- 2. Try updating all of the cities to be in the USA and roll it back

-- 3. Demonstrate two different SQL connections trying to access the same table
-- where one happens to be inside of a transaction but hasn't committed yet.