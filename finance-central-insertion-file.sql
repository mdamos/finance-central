-- Population of values for Income table
INSERT INTO Income(incomeName, hourlyWage, avgWeeklyHours) VALUES ('Walmart - Cashier', 13, 20);
INSERT INTO Income(incomeName, hourlyWage, avgWeeklyHours) VALUES ('Target - Cashier', 17, 10);
INSERT INTO Income(incomeName, hourlyWage, avgWeeklyHours) VALUES ('Campus Shop - Janitor', 7.25, 5);

-- Population of values for Expenses table
INSERT INTO Expenses(expenseName, amount, category, month, day, 
year, incomeID) VALUES ('Walmart', 50, 'Shopping',  'January', 1, 2019, 100);
INSERT INTO Expenses(expenseName, amount, category, month, day, 
year, incomeID) VALUES ('Hair Salon', 250, 'Hair Care',  'February', 1, 2019, 100);
INSERT INTO Expenses(expenseName, amount, category, month, day, 
year, incomeID) VALUES ('Bahamas', 2000, 'Vacation',  'March', 2, 2019, 100);
INSERT INTO Expenses(expenseName, amount, category, month, day, 
year, incomeID) VALUES ('Braces', 3000, 'Dental',  'April', 10, 2019, 100);
INSERT INTO Expenses(expenseName, amount, category, month, day, 
year, incomeID) VALUES ('Rent', 650, 'Housing',  'April', 15, 2019, 100);
INSERT INTO Expenses(expenseName, amount, category, month, day, 
year, incomeID) VALUES ('Whole Foods', 60, 'Shopping',  'January', 18, 2019, 100);

-- Population of values for Goals table
INSERT INTO Goals(name, goalDescription, goalTarget, goalCurrent, incomeID) VALUES
('Save for Car', 'I want to save up for a new car.', 7000, 1000, 100);
INSERT INTO Goals(name, goalDescription, goalTarget, goalCurrent, incomeID) VALUES
('Loan Payment', 'I want to save up enough money to pay off my loans.', 10000, 500, 101)
INSERT INTO Goals(name, goalDescription, goalTarget, goalCurrent, incomeID) VALUES
('House', 'I want to purchase my first home.', 100000, 2000, 101);


-- Population of values for FinancialAidAmt
INSERT INTO FinancialAidAmt(finAidName, finAidType, finAidAmount) VALUES (
'Gates Millennium', 'Scholarship', 100000
);
INSERT INTO FinancialAidAmt(finAidName, finAidType, finAidAmount) VALUES (
'Pell Grant', 'Grant', 5000
);
INSERT INTO FinancialAidAmt(finAidName, finAidType, finAidAmount) VALUES (
'Unsubsidized', 'Loan', 3500
);
INSERT INTO FinancialAidAmt(finAidName, finAidType, finAidAmount) VALUES (
'Parents', 'Other', 500
);

-- Population of values for FinancialAidType table
INSERT INTO FinancialAidType(typeName) VALUES ('Scholarship');
INSERT INTO FinancialAidType(typeName) VALUES ('Grant');
INSERT INTO FinancialAidType(typeName) VALUES ('Loan');
INSERT INTO FinancialAidType(typeName) VALUES ('Other');