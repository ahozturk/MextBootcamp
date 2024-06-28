using Microsoft.Extensions.Caching.Memory;
using StudentsApp.Domain;
using StudentsApp.Infrastructure;

AppDbContext context = new();

MemoryCache cache = new(new MemoryCacheOptions()
{
    ExpirationScanFrequency = TimeSpan.FromDays(1),
});

var lecturesFromCache = cache.Get<List<Lecture>>("LecturesCacheKey");

List<Lecture> lectures = null;

if (lecturesFromCache == null)
{
    lectures = context.Lectures.ToList();
    cache.Set("LecturesCacheKey", lectures);
}




