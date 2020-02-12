﻿-- The following queries utilize the "world" database.
-- Write queries for the following problems. 
-- Notes:
--   GNP is expressed in units of one million US Dollars
--   The value immediately after the problem statement is the expected number 
--   of rows that should be returned by the query.

-- 1. The name and state plus population of all cities in states that border Ohio 
-- (i.e. cities located in Pennsylvania, West Virginia, Kentucky, Indiana, and 
-- Michigan).  
-- The name and state should be returned as a single column called 
-- name_and_state and should contain values such as ‘Detroit, Michigan’.  
-- The results should be ordered alphabetically by state name and then by city 
-- name. 
-- (19 rows)
SELECT (name + ', ' + district) AS name_and_state
FROM city 
WHERE district IN ('Pennsylvania', 'West Virginia', 'Kentucky', 'Indiana', 'Michigan')
ORDER BY district ASC, name ASC


-- 2. The name, country code, and region of all countries in Africa.  The name and
-- country code should be returned as a single column named country_and_code 
-- and should contain values such as ‘Angola (AGO)’ 
-- (58 rows)
SELECT (name + ' (' + code + ')'), region
FROM country
WHERE continent = 'Africa'


-- 3. The per capita GNP (i.e. GNP multipled by 1000000 then divided by population) of all countries in the 
-- world sorted from highest to lowest. Recall: GNP is express in units of one million US Dollars 
-- (highest per capita GNP in world: 37459.26)

SELECT name, (gnp*1000000/population) as per_capita_GNP
FROM country
WHERE population > 0
ORDER BY per_capita_GNP DESC

-- 4. The average life expectancy of countries in South America.
-- (average life expectancy in South America: 70.9461)

SELECT AVG(lifeexpectancy) as avg_life_expectancy_South_America
FROM country
WHERE continent = 'South America'

-- 5. The sum of the population of all cities in California.
-- (total population of all cities in California: 16716706)

SELECT SUM(population) as total_population_all_cities_California
FROM city
WHERE district = 'California'

-- 6. The sum of the population of all cities in China.
-- (total population of all cities in China: 175953614)


SELECT SUM(population) as total_population_all_cities_China
FROM city
WHERE countrycode = 'CHN'

-- 7. The maximum population of all countries in the world.
-- (largest country population in world: 1277558000)

SELECT MAX(population) as largest_country_population_world
FROM country

-- 8. The maximum population of all cities in the world.
-- (largest city population in world: 10500000)

SELECT MAX(population) as largest_city_population_world
FROM city

-- 9. The maximum population of all cities in Australia.
-- (largest city population in Australia: 3276207)

SELECT MAX(population) as largest_city_population_Austrailia
FROM city 
WHERE countrycode = 'AUS'

-- 10. The minimum population of all countries in the world.
-- (smallest_country_population in world: 50)

SELECT MIN(population) as smallest_country_population_world
FROM country
WHERE population <> 0 AND population IS NOT NULL;



-- 11. The average population of cities in the United States.
-- (avgerage city population in USA: 286955.3795)

SELECT AVG(population) AS average_city_population_USA
FROM city 
WHERE countrycode = 'USA'

-- 12. The average population of cities in China.
-- (average city population in China: 484720.6997 approx.)

SELECT AVG(population) AS average_city_population_China
FROM city
WHERE countrycode = 'CHN'

-- 13. The surface area of each continent ordered from highest to lowest.
-- (largest continental surface area: 31881000, "Asia")

SELECT continent, SUM(surfacearea) as largest_continental_surface_area
FROM country
GROUP BY continent


-- 14. The highest population density (population divided by surface area) of all 
-- countries in the world. 
-- (highest population density in world: 26277.7777)

SELECT MAX(population/surfacearea) AS highest_population_density_world
FROM country

-- 15. The population density and life expectancy of the top ten countries with the 
-- highest life expectancies in descending order. 
-- (highest life expectancies in world: 83.5, 166.6666, "Andorra")

SELECT TOP 10 name, (population/surfacearea) as population_density, lifeexpectancy
FROM country
ORDER BY lifeexpectancy DESC


-- 16. The difference between the previous and current GNP of all the countries in 
-- the world ordered by the absolute value of the difference. Display both 
-- difference and absolute difference.
-- (smallest difference: 1.00, 1.00, "Ecuador")

SELECT (gnp - gnpold) AS difference, ABS(gnp - gnpold) as absolute_difference, name
FROM country 
WHERE gnp IS NOT NULL AND gnpold IS NOT NULL
ORDER BY absolute_difference ASC

-- 17. The average population of cities in each country (hint: use city.countrycode)
-- ordered from highest to lowest.
-- (highest avg population: 4017733.0000, "SGP")

SELECT AVG(population) as average_population_cities_in_each_country, countrycode
FROM city
GROUP BY city.countrycode
ORDER BY average_population_cities_in_each_country DESC

	
-- 18. The count of cities in each state in the USA, ordered by state name.
-- (45 rows)

SELECT district, COUNT(name)
FROM city
WHERE countrycode = 'USA'
GROUP BY district
ORDER BY district ASC
	
-- 19. The count of countries on each continent, ordered from highest to lowest.
-- (highest count: 58, "Africa")

SELECT continent, COUNT(name) as countries_per_continent
FROM country
GROUP by continent 
ORDER BY countries_per_continent DESC

	
-- 20. The count of cities in each country ordered from highest to lowest.
-- (largest number of  cities ib a country: 363, "CHN")

SELECT COUNT(name) AS cities_per_country, countrycode
FROM city
GROUP BY countrycode
ORDER BY cities_per_country DESC

	
-- 21. The population of the largest city in each country ordered from highest to 
-- lowest.
-- (largest city population in world: 10500000, "IND")

SELECT MAX(population) as largest_city, countrycode
FROM city
GROUP BY countrycode
ORDER BY largest_city DESC


-- 22. The average, minimum, and maximum non-null life expectancy of each continent 
-- ordered from lowest to highest average life expectancy. 
-- (lowest average life expectancy: 52.5719, 37.2, 76.8, "Africa")

SELECT AVG(lifeexpectancy) AS average_life_expectancy, MIN(lifeexpectancy) 
AS minimum_life_expectancy, MAX(lifeexpectancy) AS maxiumum_life_expectancy, continent
FROM country
WHERE lifeexpectancy IS NOT NULL
GROUP BY continent
ORDER BY average_life_expectancy ASC
