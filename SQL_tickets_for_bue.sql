create view tickets_for_buy as
SELECT 
dbo.tickets.ticket_id AS '����� ������', 
dbo.type_tickets.type_name AS '�����', 
dbo.type_tickets.raffle_date AS '���� ���������', 
dbo.type_tickets.price AS '����', 
dbo.type_tickets.x_price AS '��������� ��������'
FROM dbo.tickets INNER JOIN dbo.type_tickets 
ON dbo.tickets.type_id = dbo.type_tickets.type_id
where dbo.tickets.user_id is NULL;