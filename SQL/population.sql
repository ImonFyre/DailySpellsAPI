insert into "DailySpells"."Races" values  ('Dwarf'), ('Elf'), ('Halfling'), ('Human'), ('Dragonborn'),('Gnome'),('Half-Elf'),
								('Half-Orc'),('Tiefling'),('Drow Elf');


insert into "DailySpells"."Classes"("ClassName") values  ('Barbarian'), ('Bard'), ('Cleric'), ('Druid'), ('Fighter'),('Monk'),('Paladin'),
								('Ranger'),('Rogue'),('Sorcerer'),('Warlock'),('Wizard');
								

insert into "DailySpells"."Character"("Name", race) 
values ('Drizzt', (select id from "DailySpells"."Races" where "Name" = 'Drow Elf')),
		('Wulfgar', (select id from "DailySpells"."Races" where "Name" = 'Human')),
		('Regis', (select id from "DailySpells"."Races" where "Name" = 'Halfling')),
		('Breunor', (select id from "DailySpells"."Races" where "Name" = 'Dwarf'));


insert into "DailySpells"."CharacterClass"("characterId", "classId", level) 
		values ((select id from "DailySpells"."Character" where "Name" = 'Drizzt'),
					(select id from "DailySpells"."Classes" where "ClassName" = 'Barbarian'),
			   3),
			   ((select id from "DailySpells"."Character" where "Name" = 'Drizzt'),
					(select id from "DailySpells"."Classes" where "ClassName" = 'Fighter'),
			   11),
			   ((select id from "DailySpells"."Character" where "Name" = 'Drizzt'),
					(select id from "DailySpells"."Classes" where "ClassName" = 'Ranger'),
			   7),
			   ((select id from "DailySpells"."Character" where "Name" = 'Wulfgar'),
					(select id from "DailySpells"."Classes" where "ClassName" = 'Barbarian'),
			   7),
			   ((select id from "DailySpells"."Character" where "Name" = 'Wulfgar'),
					(select id from "DailySpells"."Classes" where "ClassName" = 'Fighter'),
			   4),
			   ((select id from "DailySpells"."Character" where "Name" = 'Regis'),
					(select id from "DailySpells"."Classes" where "ClassName" = 'Rogue'),
			   7),
			   ((select id from "DailySpells"."Character" where "Name" = 'Bruenor'),
					(select id from "DailySpells"."Classes" where "ClassName" = 'Fighter'),
			   14);

insert into "DailySpells"."CharacterStats" ("characterId", "str", "dex", "con", "int", "wis", "cha") 
values ((select id from "DailySpells"."Character" where "Name" = 'Drizzt'), 13, 20, 15, 17, 17, 15),
		((select id from "DailySpells"."Character" where "Name" = 'Wulfgar'), 20, 15, 17, 13, 12, 13),
		((select id from "DailySpells"."Character" where "Name" = 'Regis'), 10, 18, 15, 13, 15, 15),
		((select id from "DailySpells"."Character" where "Name" = 'Bruenor'), 18, 14, 22, 15, 13, 13);


select c."Name", r."Name", cs.str, cs.dex, cs.con, cs.int, cs.wis, cs.cha, cc.level, cl."ClassName" 
from "DailySpells"."Character" c
inner join "DailySpells"."CharacterStats" cs on cs."characterId" = c."id"
inner join "DailySpells"."CharacterClass" cc on cc."characterId" = c."id"
inner join "DailySpells"."Classes" cl on cl.id  = cc."classId"
inner join "DailySpells"."Races" r on r.id  = c.race;