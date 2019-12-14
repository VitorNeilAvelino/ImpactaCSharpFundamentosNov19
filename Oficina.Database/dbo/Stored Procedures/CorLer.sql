Create proc CorLer
	@id int
as
Select Id, Nome from Cor where Id = @id