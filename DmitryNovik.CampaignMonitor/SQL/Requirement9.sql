
SELECT S.[Name] 
FROM Salesperson S
JOIN Orders O ON O.SalespersonID = S.SalespersonID
JOIN Customer C ON C.CustomerID = O.CustomerID
-- Note that in the real life there might be multiple Georges
-- so that one should join by CustomerID rather than plain name
WHERE C.Name = 'George' 


SELECT S.[Name] 
FROM Salesperson S
WHERE NOT EXISTS (SELECT 1 FROM Orders O
	JOIN Customer C ON O.CustomerID = C.CustomerID
	-- Note that in the real life there might be multiple Georges
	-- so that one should join by CustomerID rather than plain name
	WHERE O.SalespersonID = S.SalespersonID AND C.Name = 'George')


SELECT S.[Name] 
FROM Salesperson S
JOIN Orders O ON O.SalespersonID = S.SalespersonID
GROUP BY S.[Name]
HAVING COUNT(Name) > 1
