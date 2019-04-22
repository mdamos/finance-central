-- Author: Michelle Amos

CREATE TABLE Income (
    incomeID            INT NOT NULL IDENTITY(100,1),
    incomeName          VARCHAR(30),
    hourlyWage          MONEY,
    avgWeeklyHours      INT,
    PRIMARY KEY (incomeID)
);

CREATE TABLE Expenses (
    expenseID           INT NOT NULL IDENTITY(1000,1),
    expenseName         VARCHAR(30) NOT NULL,
    amount              MONEY,
    category            VARCHAR(30), -- Example: Shopping, groceries, etc.
    month               VARCHAR(9),
    day                 INT,
    year                INT,
    incomeID            INT,
    PRIMARY KEY (expenseID),
    FOREIGN KEY (incomeID) REFERENCES Income(incomeID)
);

CREATE TABLE Goals (
    goalID              INT NOT NULL IDENTITY(1,1),
    name                VARCHAR(30) NOT NULL,
    goalDescription     VARCHAR(150),
    goalTarget          MONEY,
    goalCurrent         MONEY,
    incomeID            INT,
    PRIMARY KEY (goalID),
    FOREIGN KEY (incomeID) REFERENCES Income(incomeID)
);

-- Tracking financial aid
CREATE TABLE FinancialAidType (
    typeName      VARCHAR(30) NOT NULL,
    PRIMARY KEY (typeName)
);

CREATE TABLE FinancialAidAmt (
    finAidName        VARCHAR(30) NOT NULL, -- Example: McDonald's Giving
    finAidType        VARCHAR(30) NOT NULL, -- Example: Scholarship
    finAidAmount      MONEY,
    PRIMARY KEY (finAidName),
    FOREIGN KEY (finAidType) REFERENCES FinancialAidType(typeName)
);

SELECT *
FROM Expenses;