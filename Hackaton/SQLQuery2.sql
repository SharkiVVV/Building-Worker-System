INSERT INTO Users ([Name], Surname)
VALUES
('Victor', 'Petrovich'),
('Ivan', 'West'),
('Scott', 'Reyes'),
('Dennis', 'Diaz');

-- Вставить данные в таблицу Role
INSERT INTO [Role] ([role])
VALUES
('admin'),
('executor');

-- Вставить данные в таблицу Building
INSERT INTO Building (title)
VALUES
('Dreedguch'),
('Lownalv'),
('Pancee');

-- Вставить данные в таблицу Decision
INSERT INTO Decision (building_id, decision_date, decision_text)
VALUES
(1, GETDATE(), 'demolition'),
(2, GETDATE(), 'restoration'),
(3, GETDATE(), 'demolition');

-- Вставить данные в таблицу Conclusion
INSERT INTO Conclusion ([users_id], building_id, decision_date, conclusion_text)
VALUES
(1, 1, GETDATE(), 'demolition for building 1'),
(2, 2, GETDATE(), 'restoration for building 2'),
(3, 3, GETDATE(), 'demolition for building 3');

-- Вставить данные в таблицу UserRole
INSERT INTO UsersRole (users_id, role_id)
VALUES
(1, 1),
(2, 2),
(3, 2),
(4, 2);

-- Вставить данные в таблицу Connection_Building
INSERT INTO Connection_Building (building_id, decision_id)
VALUES
(1, 1),
(2, 2),
(3, 3);
