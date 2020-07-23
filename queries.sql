--удаление ниже проходного

delete from Оценки
where Оценки.Предмет = 'Физика' and Оценки.Балл <= 50

delete from Оценки
where Оценки.Предмет = 'Русский язык' and Оценки.Балл <= 55

delete from Оценки
where Оценки.Предмет = 'Математика' and Оценки.Балл <= 47

delete from Оценки
where Оценки.Предмет = 'Информатика и ИКТ' and Оценки.Балл <= 53

delete from Оценки
where Оценки.Предмет = 'Обществознание' and Оценки.Балл <= 53

delete from Оценки
where Оценки.Предмет = 'Химия' and Оценки.Балл <= 52

delete from Оценки
where Оценки.Предмет = 'Творческий конкурс' and Оценки.Балл <= 52

delete from Оценки
where Оценки.Предмет = 'География' and Оценки.Балл <= 55

-- вывод по средним (учебное заведение)

select *
from (
select top 5000 avg(Балл) as [Средний балл], Учебное_Заведение, Город
from Оценки
inner join Поступающие on Оценки.ID = Поступающие.ID
where Оценки.Предмет = 'Физика' 
group by Учебное_Заведение, Город
order by Город, Учебное_Заведение desc) as Таблица
order by Таблица.[Средний балл] desc

select *
from (
select top 5000 avg(Балл) as [Средний балл], Учебное_Заведение, Город
from Оценки
inner join Поступающие on Оценки.ID = Поступающие.ID
where Оценки.Предмет = 'Русский язык' 
group by Учебное_Заведение, Город
order by Город, Учебное_Заведение desc) as Таблица
order by Таблица.[Средний балл] desc

select *
from (
select top 5000 avg(Балл) as [Средний балл], Учебное_Заведение, Город
from Оценки
inner join Поступающие on Оценки.ID = Поступающие.ID
where Оценки.Предмет = 'Математика' 
group by Учебное_Заведение, Город
order by Город, Учебное_Заведение desc) as Таблица
order by Таблица.[Средний балл] desc

select *
from (
select top 5000 avg(Балл) as [Средний балл], Учебное_Заведение, Город
from Оценки
inner join Поступающие on Оценки.ID = Поступающие.ID
where Оценки.Предмет = 'Информатика и ИКТ' 
group by Учебное_Заведение, Город
order by Город, Учебное_Заведение desc) as Таблица
order by Таблица.[Средний балл] desc

select *
from (
select top 5000 avg(Балл) as [Средний балл], Учебное_Заведение, Город
from Оценки
inner join Поступающие on Оценки.ID = Поступающие.ID
where Оценки.Предмет = 'Обществознание'
group by Учебное_Заведение, Город
order by Город, Учебное_Заведение desc) as Таблица
order by Таблица.[Средний балл] desc

select *
from (
select top 5000 avg(Балл) as [Средний балл], Учебное_Заведение, Город
from Оценки
inner join Поступающие on Оценки.ID = Поступающие.ID
where Оценки.Предмет = 'Химия'
group by Учебное_Заведение, Город
order by Город, Учебное_Заведение desc) as Таблица
order by Таблица.[Средний балл] desc

select *
from (
select top 5000 avg(Балл) as [Средний балл], Учебное_Заведение, Город
from Оценки
inner join Поступающие on Оценки.ID = Поступающие.ID
where Оценки.Предмет = 'Творческий конкурс'
group by Учебное_Заведение, Город
order by Город, Учебное_Заведение desc) as Таблица
order by Таблица.[Средний балл] desc

select *
from (
select top 5000 avg(Балл) as [Средний балл], Учебное_Заведение, Город
from Оценки
inner join Поступающие on Оценки.ID = Поступающие.ID
where Оценки.Предмет = 'География'
group by Учебное_Заведение, Город
order by Город, Учебное_Заведение desc) as Таблица
order by Таблица.[Средний балл] desc

-- вывод по средним (город)

select distinct *
from (
select top 2000 avg(Балл) as [Средний балл], Город
from Оценки
inner join Поступающие on Оценки.ID = Поступающие.ID
where Оценки.Предмет = 'Физика'
group by Город
order by Город desc) as Таблица
order by Таблица.[Средний балл] desc

select distinct *
from (
select top 2000 avg(Балл) as [Средний балл], Город
from Оценки
inner join Поступающие on Оценки.ID = Поступающие.ID
where Оценки.Предмет = 'Русский язык'
group by Город
order by Город desc) as Таблица
order by Таблица.[Средний балл] desc

select distinct *
from (
select top 2000 avg(Балл) as [Средний балл], Город
from Оценки
inner join Поступающие on Оценки.ID = Поступающие.ID
where Оценки.Предмет = 'Математика'
group by Город
order by Город desc) as Таблица
order by Таблица.[Средний балл] desc

select distinct *
from (
select top 2000 avg(Балл) as [Средний балл], Город
from Оценки
inner join Поступающие on Оценки.ID = Поступающие.ID
where Оценки.Предмет = 'Информатика и ИКТ'
group by Город
order by Город desc) as Таблица
order by Таблица.[Средний балл] desc

select distinct *
from (
select top 2000 avg(Балл) as [Средний балл], Город
from Оценки
inner join Поступающие on Оценки.ID = Поступающие.ID
where Оценки.Предмет = 'Обществознание'
group by Город
order by Город desc) as Таблица
order by Таблица.[Средний балл] desc

select distinct *
from (
select top 2000 avg(Балл) as [Средний балл], Город
from Оценки
inner join Поступающие on Оценки.ID = Поступающие.ID
where Оценки.Предмет = 'Химия'
group by Город
order by Город desc) as Таблица
order by Таблица.[Средний балл] desc

select distinct *
from (
select top 2000 avg(Балл) as [Средний балл], Город
from Оценки
inner join Поступающие on Оценки.ID = Поступающие.ID
where Оценки.Предмет = 'Творческий конкурс'
group by Город
order by Город desc) as Таблица
order by Таблица.[Средний балл] desc


select distinct *
from (
select top 2000 avg(Балл) as [Средний балл], Город
from Оценки
inner join Поступающие on Оценки.ID = Поступающие.ID
where Оценки.Предмет = 'География'
group by Город
order by Город desc) as Таблица
order by Таблица.[Средний балл] desc

select *
from Оценки
inner join Поступающие on Оценки.ID=Поступающие.ID
where Предмет = 'Химия'

-- выбор городов для карты

select Города.Город, Широта, Долгота, count(Поступающие.ID) as [Число абитуриентов], avg(Оценки.Балл) as [Cредняя_оценка]
from Поступающие
inner join Города on Города.Город = Поступающие.Город
inner join Оценки on Оценки.ID = Поступающие.ID
group by Города.Город, Широта, Долгота

