# Інтернет магазин

## Опис
Сучасний інтернет магазин з використанням сучасних стандартів побудови кросплатформенного підходу.
- для безпосередньої робти з даними використовується RESTful API interface
- для браузерів, які не підтрмують WebAssembly створено Blazor Server
- для браузерів, які підтримують WebAssembly клієнт на Blazor Pages
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

- [Syncfusion developing](https://www.syncfusion.com/)
- [Best pracice for using parameters in RESTful API](https://www.moesif.com/blog/technical/api-design/REST-API-Design-Filtering-Sorting-and-Pagination/)
- [RESTfull API](https://www.vinaysahni.com/best-practices-for-a-pragmatic-restful-api)
- [Pragim Technologi Chanal](https://www.pragimtech.com/blog/blazor-webAssembly/progressive-web-apps/)
- [Metanit](https://metanit.com/sharp/tutorial/15.1.php)
- [Microsoft Doc Scafolding](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-6.0&tabs=visual-studio)

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
 * POST .../resources (create resource and return a resource representation)
 
**Read**
 * GET .../resources.format (return the list of all resources)
 * GET .../resources/identifier.format (return a single resource)
 * GET .../resources.format?filter1=value-filter1&filter2=value-filter2 (return list of resources filtered by name and sortet desc)

**Update**
 * PUT .../resources/identifier (updates the entire resource and return a resource representation)
 * PATCH .../resources/identifier (updates only subset of the resource and return a resource representation)
 
**Delete**
 * DELETE .../resources (delete all resources)
 * DELETE .../resources/identifier (delete single resource with identifier)

### Subresources 

**Create**
 * POST .../resources/identifier/subresources (create resource and return a resource representation)

**Read**
 * GET .../resources/identifier/subresources.format

**Update**
 * PUT .../resources/identifier/subresources/identifier (update single subresource with id and return a resource representation)
 * PATCH .../resources/identifier/subresources/identifier (updates only subset of the the protpriesd of singlr subresource and return a resource representation)
 
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


- 200 OK - Response to a successful GET, PUT, PATCH or DELETE. Can also be used for a POST that doesn't result in a creation.
- 201 Created - Response to a POST that results in a creation. Should be combined with a Location header pointing to the location of the new resource
- 204 No Content - Response to a successful request that won't be returning a body (like a DELETE request)
- 304 Not Modified - Used when HTTP caching headers are in play
- 400 Bad Request - The request is malformed, such as if the body does not parse
- 401 Unauthorized - When no or invalid authentication details are provided. Also useful to trigger an auth popup if the API is used from a browser
- 403 Forbidden - When authentication succeeded but authenticated user doesn't have access to the resource
- 404 Not Found - When a non-existent resource is requested
- 405 Method Not Allowed - When an HTTP method is being requested that isn't allowed for the authenticated user
- 410 Gone - Indicates that the resource at this end point is no longer available. Useful as a blanket response for old API versions
- 415 Unsupported Media Type - If incorrect content type was provided as part of the request
- 422 Unprocessable Entity - Used for validation errors
- 429 Too Many Requests - When a request is rejected due to rate limiting