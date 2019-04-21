CREATE TABLE Income (
    incomeID            INT,
    incomeName          VARCHAR(30),
    hourlyWage          MONEY,
    avgWeeklyHours      INT,
    PRIMARY KEY (incomeID)
);

CREATE TABLE Expenses (
    expenseID       INT,
    expenseName     VARCHAR(30),
    expenseAmount   MONEY,
    incomeSourceID  INT,
    PRIMARY KEY (expenseID),
    FOREIGN KEY (incomeSourceID) REFERENCES Income(incomeID)
);

CREATE TABLE Goals (
    goalID          INT,
    goalName        VARCHAR(30),
    goalTarget      MONEY,
    goalCurrent     MONEY,
    incomeSourceID  INT,
    PRIMARY KEY (goalID),
    FOREIGN KEY (incomeSourceID) REFERENCES Income(incomeID)
);

-- Tracking financial aid
CREATE TABLE FinancialAidType (
    typeName      VARCHAR(30),
    PRIMARY KEY (typeName)
);

CREATE TABLE FinancialAidAmt (
    finAidName        VARCHAR(30),
    finAidType        VARCHAR(30),
    finAidAmount      MONEY,
    PRIMARY KEY (finAidName),
    FOREIGN KEY (finAidType) REFERENCES FinancialAidType(typeName)
);