select Businesses.Business, COALESCE(Premises.StreetNo,''), Premises.Street, Premises.PostCode, SUM(Footfall.Count) as FootfallCount
from Businesses inner join Premises on Premises.BusinessId = Businesses.Id inner join Footfall on Premises.Id = Footfall.PremisesId
GROUP BY Businesses.Business, Premises.StreetNo, Premises.Street, Premises.PostCode