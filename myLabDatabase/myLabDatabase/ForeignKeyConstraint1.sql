ALTER TABLE [dbo].[Items]
	ADD CONSTRAINT [ForeignKeyConstraint1]
	FOREIGN KEY (Typ)
	REFERENCES [Types] (Id)
