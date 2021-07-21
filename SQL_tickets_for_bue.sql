create view tickets_for_buy as
SELECT 
dbo.tickets.ticket_id AS 'Номер билета', 
dbo.type_tickets.type_name AS 'Акция', 
dbo.type_tickets.raffle_date AS 'Дата розыгрыша', 
dbo.type_tickets.price AS 'Цена', 
dbo.type_tickets.x_price AS 'Множитель выигрыша'
FROM dbo.tickets INNER JOIN dbo.type_tickets 
ON dbo.tickets.type_id = dbo.type_tickets.type_id
where dbo.tickets.user_id is NULL;