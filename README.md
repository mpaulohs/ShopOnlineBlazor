# Інтернет магазин

## Опис
Сучасний інтернет магазин з використанням сучасних стандартів побудови кросплатформенного підходу.
- для безпосередньої робти з даними використовується RESTful API interface
- для браузерів, які не підтрмують WebAssembly створено Blazor Server
- для браузерів, які підтримують WebAssembly слієнт на Blazor Pages
- для підтримки роботи із популярною в Україні CMR 1C підтримка роботи з стандартом ecommerce

![Structura](./Shared/PWAStructure.png)

## Технології

**IDE**
- Visual Studio 2019
- Visual Studio 2022
- Visual Code

**Мова програмування**
- C# 9
- HTML
- CSS


**Фреймворки**
- .NET 5.O
- ASP.NET Core 5.0

**Технології**
- ASP.NET Core Web API
- Blazor
- Blazor Pages
- RESTfull API


## Resources

https://www.syncfusion.com/

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

#### Resources

**Create** 
 * POST .../resources (create resource)
 
**Read**
 * GET .../resources.format (return the list of all resources)
 * GET .../resources/identifier.format (return a single resource)
 * GET .../resources.format?filter1=value-filter1&filter2=value-filter2 (return list of resources filtered by name and sortet desc)

**Update**
 * PUT .../resources/identifier (updates the entire resource)
 * PATCH .../resources/identifier (updates only subset of the resource)
 
**Delete**
 * DELETE .../resources (delete all resources)
 * DELETE .../resources/identifier (delete single resource with identifier)

### Subresources 

**Create**
 * POST .../resources/identifier/subresources

**Read**
 * GET .../resources/identifier/subresources.format

**Update**
 * PUT .../resources/identifier/subresources/identifier (update single subresource with id)
 * PATCH .../resources/identifier/subresources/identifier (updates only subset of the the protpriesd of singlr subresource)
 
**Delete**
 * DELETE .../resources/identifier/subresources (delete all subresources in single resource)
 * DELETE .../resources/identifier/subresources/identifier (delete subresource in singler resource)

**HTTP Statuses**

Since REST APIs depend upon HTTP standards, each request’s status is used to communicate the result of the request, such as success or failure. Each status code provides a machine-readable response, plus a human-readable message. Web developers (and a number of users) will be familiar with many of these.

- 200: Success
- 201: Created
- 404: Not found
- 401: Unauthorized
- 403: Forbidden
- 429: Too many requests