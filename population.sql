insert into "DailyStats"."Races" values  ('Dwarf'), ('Elf'), ('Halfling'), ('Human'), ('Dragonborn'),('Gnome'),('Half-Elf'),
								('Half-Orc'),('Tiefling'),('Drow Elf');


insert into "DailyStats"."Classes"("ClassName") values  ('Barbarian'), ('Bard'), ('Cleric'), ('Druid'), ('Fighter'),('Monk'),('Paladin'),
								('Ranger'),('Rogue'),('Sorcerer'),('Warlock'),('Wizard');
								

insert into "DailyStats"."Character"("Name", race) 
values ('Drizzt', (select id from "DailyStats"."Races" where "Name" = 'Drow Elf')),
		('Wulfgar', (select id from "DailyStats"."Races" where "Name" = 'Human')),
		('Regis', (select id from "DailyStats"."Races" where "Name" = 'Halfling')),
		('Breunor', (select id from "DailyStats"."Races" where "Name" = 'Dwarf'));


insert into "DailyStats"."CharacterClass"("characterId", "classId", level) 
		values ((select id from "DailyStats"."Character" where "Name" = 'Drizzt'),
					(select id from "DailyStats"."Classes" where "ClassName" = 'Barbarian'),
			   3),
			   ((select id from "DailyStats"."Character" where "Name" = 'Drizzt'),
					(select id from "DailyStats"."Classes" where "ClassName" = 'Fighter'),
			   11),
			   ((select id from "DailyStats"."Character" where "Name" = 'Drizzt'),
					(select id from "DailyStats"."Classes" where "ClassName" = 'Ranger'),
			   7),
			   ((select id from "DailyStats"."Character" where "Name" = 'Wulfgar'),
					(select id from "DailyStats"."Classes" where "ClassName" = 'Barbarian'),
			   7),
			   ((select id from "DailyStats"."Character" where "Name" = 'Wulfgar'),
					(select id from "DailyStats"."Classes" where "ClassName" = 'Fighter'),
			   4),
			   ((select id from "DailyStats"."Character" where "Name" = 'Regis'),
					(select id from "DailyStats"."Classes" where "ClassName" = 'Rogue'),
			   7),
			   ((select id from "DailyStats"."Character" where "Name" = 'Bruenor'),
					(select id from "DailyStats"."Classes" where "ClassName" = 'Fighter'),
			   14);

insert into "DailyStats"."CharacterStats" ("characterId", "str", "dex", "con", "int", "wis", "cha") 
values ((select id from "DailyStats"."Character" where "Name" = 'Drizzt'), 13, 20, 15, 17, 17, 15),
		((select id from "DailyStats"."Character" where "Name" = 'Wulfgar'), 20, 15, 17, 13, 12, 13),
		((select id from "DailyStats"."Character" where "Name" = 'Regis'), 10, 18, 15, 13, 15, 15),
		((select id from "DailyStats"."Character" where "Name" = 'Bruenor'), 18, 14, 22, 15, 13, 13);


select c."Name", r."Name", cs.str, cs.dex, cs.con, cs.int, cs.wis, cs.cha, cc.level, cl."ClassName" 
from "DailyStats"."Character" c
inner join "DailyStats"."CharacterStats" cs on cs."characterId" = c."id"
inner join "DailyStats"."CharacterClass" cc on cc."characterId" = c."id"
inner join "DailyStats"."Classes" cl on cl.id  = cc."classId"
inner join "DailyStats"."Races" r on r.id  = c.race;