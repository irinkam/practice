--�������� ���� ����������

delete from ������
where ������.������� = '������' and ������.���� <= 50

delete from ������
where ������.������� = '������� ����' and ������.���� <= 55

delete from ������
where ������.������� = '����������' and ������.���� <= 47

delete from ������
where ������.������� = '����������� � ���' and ������.���� <= 53

delete from ������
where ������.������� = '��������������' and ������.���� <= 53

delete from ������
where ������.������� = '�����' and ������.���� <= 52

delete from ������
where ������.������� = '���������� �������' and ������.���� <= 52

delete from ������
where ������.������� = '���������' and ������.���� <= 55

-- ����� �� ������� (������� ���������)

select *
from (
select top 5000 avg(����) as [������� ����], �������_���������, �����
from ������
inner join ����������� on ������.ID = �����������.ID
where ������.������� = '������' 
group by �������_���������, �����
order by �����, �������_��������� desc) as �������
order by �������.[������� ����] desc

select *
from (
select top 5000 avg(����) as [������� ����], �������_���������, �����
from ������
inner join ����������� on ������.ID = �����������.ID
where ������.������� = '������� ����' 
group by �������_���������, �����
order by �����, �������_��������� desc) as �������
order by �������.[������� ����] desc

select *
from (
select top 5000 avg(����) as [������� ����], �������_���������, �����
from ������
inner join ����������� on ������.ID = �����������.ID
where ������.������� = '����������' 
group by �������_���������, �����
order by �����, �������_��������� desc) as �������
order by �������.[������� ����] desc

select *
from (
select top 5000 avg(����) as [������� ����], �������_���������, �����
from ������
inner join ����������� on ������.ID = �����������.ID
where ������.������� = '����������� � ���' 
group by �������_���������, �����
order by �����, �������_��������� desc) as �������
order by �������.[������� ����] desc

select *
from (
select top 5000 avg(����) as [������� ����], �������_���������, �����
from ������
inner join ����������� on ������.ID = �����������.ID
where ������.������� = '��������������'
group by �������_���������, �����
order by �����, �������_��������� desc) as �������
order by �������.[������� ����] desc

select *
from (
select top 5000 avg(����) as [������� ����], �������_���������, �����
from ������
inner join ����������� on ������.ID = �����������.ID
where ������.������� = '�����'
group by �������_���������, �����
order by �����, �������_��������� desc) as �������
order by �������.[������� ����] desc

select *
from (
select top 5000 avg(����) as [������� ����], �������_���������, �����
from ������
inner join ����������� on ������.ID = �����������.ID
where ������.������� = '���������� �������'
group by �������_���������, �����
order by �����, �������_��������� desc) as �������
order by �������.[������� ����] desc

select *
from (
select top 5000 avg(����) as [������� ����], �������_���������, �����
from ������
inner join ����������� on ������.ID = �����������.ID
where ������.������� = '���������'
group by �������_���������, �����
order by �����, �������_��������� desc) as �������
order by �������.[������� ����] desc

-- ����� �� ������� (�����)

select distinct *
from (
select top 2000 avg(����) as [������� ����], �����
from ������
inner join ����������� on ������.ID = �����������.ID
where ������.������� = '������'
group by �����
order by ����� desc) as �������
order by �������.[������� ����] desc

select distinct *
from (
select top 2000 avg(����) as [������� ����], �����
from ������
inner join ����������� on ������.ID = �����������.ID
where ������.������� = '������� ����'
group by �����
order by ����� desc) as �������
order by �������.[������� ����] desc

select distinct *
from (
select top 2000 avg(����) as [������� ����], �����
from ������
inner join ����������� on ������.ID = �����������.ID
where ������.������� = '����������'
group by �����
order by ����� desc) as �������
order by �������.[������� ����] desc

select distinct *
from (
select top 2000 avg(����) as [������� ����], �����
from ������
inner join ����������� on ������.ID = �����������.ID
where ������.������� = '����������� � ���'
group by �����
order by ����� desc) as �������
order by �������.[������� ����] desc

select distinct *
from (
select top 2000 avg(����) as [������� ����], �����
from ������
inner join ����������� on ������.ID = �����������.ID
where ������.������� = '��������������'
group by �����
order by ����� desc) as �������
order by �������.[������� ����] desc

select distinct *
from (
select top 2000 avg(����) as [������� ����], �����
from ������
inner join ����������� on ������.ID = �����������.ID
where ������.������� = '�����'
group by �����
order by ����� desc) as �������
order by �������.[������� ����] desc

select distinct *
from (
select top 2000 avg(����) as [������� ����], �����
from ������
inner join ����������� on ������.ID = �����������.ID
where ������.������� = '���������� �������'
group by �����
order by ����� desc) as �������
order by �������.[������� ����] desc


select distinct *
from (
select top 2000 avg(����) as [������� ����], �����
from ������
inner join ����������� on ������.ID = �����������.ID
where ������.������� = '���������'
group by �����
order by ����� desc) as �������
order by �������.[������� ����] desc

select *
from ������
inner join ����������� on ������.ID=�����������.ID
where ������� = '�����'

-- ����� ������� ��� �����

select ������.�����, ������, �������, count(�����������.ID) as [����� ������������], avg(������.����) as [C������_������]
from �����������
inner join ������ on ������.����� = �����������.�����
inner join ������ on ������.ID = �����������.ID
group by ������.�����, ������, �������

