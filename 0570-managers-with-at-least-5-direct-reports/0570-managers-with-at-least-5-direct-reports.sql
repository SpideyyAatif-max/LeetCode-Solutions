# Write your MySQL query statement below
select e.name from Employee e
join Employee m on e.id = m.managerId 
group by e.name, e.id
Having Count(m.id)>=5

# DOne. nice stuff