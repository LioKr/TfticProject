INSERT INTO [dbo].[Character](Firstname,Lastname,Nickname,Race, [Role],CharacterDescription, LastEdit)
VALUES	
	('Terry','Pratchett','Terry Pratchett', 'Human', 'Author', 'Author',null),
	(null, null,'Death',null,'Death','Death is, as you’d expect, a tall, hooded skeleton with a scythe, and SPEAKS IN A VOICE LIKE THE SLAMMING OF COFFIN LIDS. However, he also likes a good curry, and kittens, and finds the lives of mortals endlessly fascinating.',null),		('Sam', 'Vimes', 'Sam','Human','Guard','Sam Vimes is an old-fashioned copper. He, and the City Watch he commands, started in the gutter (one outside a pub), and Vimes takes care not to forget it, wearing extra thin boots so he can feel the streets of his city as he proceeds along them, cigar in hand, gimlet eyes peeled not just for crime, which being extremely cynical he suspects everyone of, but also injustice, which makes him very angry.',null),
	('unknown','Rincewind','Rincewind','Human','Wizzard','Rincewind is the Disc’s most useless wizard – he can’t even spell wizzard, and his most notable talent is running away, very fast. But somehow whenever anyone wants a wizard for a terrifying quest, it is Rincewind they call on.',null),
	('Esmeralda','Weatherwax','Granny Weatherwax','Human','Witch','She is a witch and member of the Lancre coven. She is the self-appointed guardian of her small country, and frequently defends it against supernatural powers. Granny Weatherwax has a near-unshakeable belief in her own abilities, which has proven accurate, and an extreme distrust of stories.',null),
	('Moist','von Lipwig', 'Moit von Lipwig','Human','Conman','Moist von Lipwig is a cheat and a swindler and a conman. So he’s the natural choice whenever an ailing institution like the Post Office or the Royal Bank needs new management. With a taste for flashy suits and even flashier publicity stunts, he takes on some of the worst jobs on the Disc and battles even bigger crooks than himself.',null),
	('Tiffany','Aching', 'Tiffany Aching', 'Human','Witch','Tiffany Aching is a young witch – as well as a social worker and cheese maker extraordinaire. She hails from a long line of shepherds and has a powerful connection with the Chalk where she lives. Wherever Tiffany goes, it’s almost certain that there will be a horde of tiny fightin’, boozin’ blue men in kilts – the Nac Mac Feegles – not far away.',null),
	('Havelock','Vetinari','Lord Vetinari', 'Human','Patrician','He is depicted as the ruler of the city-state of Ankh-Morpork.',null)
	
INSERT INTO Person(Firstname,Lastname,Birthdate,Deathdate)
VALUES
	('Terry','Pratchett','19480428','20150312'),
	('Neil','Gaiman','19601110',null)

INSERT INTO Author(Biography,PersonId)
VALUES
	('He had his first story published when he was just thirteen. After leaving school at seventeen to become a journalist he continued writing, publishing his first novel, The Carpet People, in 1971 and going on to produce the phenomenally successful Discworld series. Terry proved early critics wrong and became one of the UK’s most successful authors, receiving a knighthood in 2009 and seeing many of his books adapted for the screen.',1),
	('He is an English author of short fiction, novels, comic books, graphic novels, nonfiction, audio theatre, and films. His works include the comic book series The Sandman and novels Stardust, American Gods, Coraline, and The Graveyard Book. He has won numerous awards, including the Hugo, Nebula, and Bram Stoker awards, as well as the Newbery and Carnegie medals.',2)

INSERT INTO Saga(SagaName)
VALUES
	('Rincewind'),
	('Witches'),
	('Death'),
	('City Watch'),
	('Moit von Lipwig')


INSERT INTO Book(BookId,Title, ReleaseYear, IsDiscWorld,SagaName)
VALUES 
	(1,'The Colour Of Magic',1983,1,'Rincewind'),
	(3,'Equal Rites',1987,1,'Witches'),
	(4,'Mort',1987,1,'Death'),
	(8,'Guards! Guards!',1989,1,'City Watch'),
	(9,'Eric',1990,1,'Rincewind'),
	(12,'Witches Abroad',1991,1,'Witches'),
	(15,'Men At Arms',1993,1,'City Watch'),
	(22,'Last Continent',1998,1,'Rincewind'),
	(33, 'Going Postal', 2004,1,'Moit von Lipwig'),
	(29,'Night Watch',2002,1,'City Watch'),
	(39,'Snuff',2011,1,'City Watch'),
	(50,'Good Omens',1990,0,null) 

INSERT INTO Quote(Content, Quote_Author, Quote_Book)
VALUES 
	('It is said that your life flashes before your eyes just before you die. That is true, it''s called Life.', null, 'Last Continent'),
	('A good bookshop is just a genteel Black Hole that knows how to read.',null,'Guards! Guards!'),
	('Do you not know that a man is not dead while his name is still spoken?',null,'Going Postal'),
	('If you stop tellin'' people it''s all sorted out after they''re dead, they might try sorting it all out while they''re alive.',null,'Good Omens'),
	('Goodness is about what you do. Not who you pray to.',null,'Snuff')

Exec SP_Add_User @firstname='Admin',@lastname='Admin',@email='Admin', @userName='Admin',@password='Admin',@role='A'
Exec SP_Add_User @firstname='Casual',@lastname='Casual',@email='Casual', @userName='Casual',@password='Casual',@role='C'
Exec SP_Add_User @firstname='Lurker',@lastname='Lurker',@email='Lurker', @userName='Lurker',@password='Lurker',@role='C'