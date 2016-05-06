SELECT TOP 3 u.UserId, u.Username, u.Password, u.Email, u.Address, u.City, u.Phone
FROM Rental r
JOIN User u
	ON r.UserID = u.UserID
ORDER BY r.Quantity Desc
