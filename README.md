# Інтернет магазин

## Опис
Сучасний інтернет магазин з використанням сучасних стандартів побудови кросплатформенного підходу.
- для безпосередньої робти з даними використовується RESTful API interface
- для браузерів, які не підтрмують Web Assembly створено Blazor Server
- для браузерів, які підтримують Web Assembly слієнт на Blazor Pages
- для підтримки роботи із популярною в Україні CMR 1C підтримка ро

## Технології

Мова програмування: C#
Фреймворки:
- .Net 5
- Blazor Server
- Blazor Pages

'''

## REST API
### naming convention:

*protocol://host:port/api/version/resources/identifier/subresources/identifier*

*hppt://localhost:5000/api/v1/orders/1/items.json*

**protocol:**
- http (Hiper Text Transfer Protocol)
- https (Hiper Text Transfer Protocol Securied)

**host** (name of host server)

**port** (listening port for host server)

**api** - optional name to define that this is api uri

**version** - api version (not decimal)

**resources** - base resource name

**identifire** - id of resource

**subresources** - resources in base resource

**format** - the format of reciving data
- json
- csv
- xml

### Resources 

**Recive a list of resources**
* GET .../resources.format (return list of all resources in json format)

**Recive a single resource**

 * GET .../resources/identifier.format (return single resource in json format)

**Filtering list of resources**
 * GET .../resources.format?filter1=value-filter1&filter2=value-filter2 (return list of resources filtered by name and sortet desc)

**Create new resource** 
 * POST .../resources (create resource)
 
**Update resource**
 * PUT .../resources/identifier (update resources)
 
**Delete resource**
 * DELETE .../resources (delete all resources)
 * DELETE .../resources/identifier (delete single resource with identifier)

### Subresources 

**List of all subresources in resource**
 * GET .../resources/identifier/subresources.format

**Add new subresource in resource**
 * POST .../resources/identifier/subresources

**Update subresource in resource**
 * PUT .../resources/identifier/subresources/identifier (update single subresource with id)

**Delete subresources from resource**
 * DELETE .../resources/identifier/subresources (delete all subresources in single resource)
 * DELETE .../resources/identifier/subresources/identifier (delete subresource in singler resource)