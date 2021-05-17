### Multi-Tier-Architecture-with-Nortwind

# N-tier architecture style with using C#/Northwind database

An N-tier architecture divides an application into logical layers and physical tiers.

![n-tier-physical-bastion](https://user-images.githubusercontent.com/73894794/118513495-6e37bf00-b73c-11eb-8501-61215e1a3f97.png)


Layers are a way to separate responsibilities and manage dependencies. Each layer has a specific responsibility. A higher layer can use services in a lower layer, but not the other way around.

Tiers are physically separated, running on separate machines. A tier can call to another tier directly, or use asynchronous messaging (message queue). Although each layer might be hosted in its own tier, that's not required. Several layers might be hosted on the same tier. Physically separating the tiers improves scalability and resiliency, but also adds latency from the additional network communication.

A traditional three-tier application has a presentation tier, a middle tier, and a database tier. The middle tier is optional. More complex applications can have more than three tiers. The diagram above shows an application with two middle tiers, encapsulating different areas of functionality.

An N-tier application can have a closed layer architecture or an open layer architecture:

In a closed layer architecture, a layer can only call the next layer immediately down.
In an open layer architecture, a layer can call any of the layers below it.
A closed layer architecture limits the dependencies between layers. However, it might create unnecessary network traffic, if one layer simply passes requests along to the next layer.

When to use this architecture
N-tier architectures are typically implemented as infrastructure-as-service (IaaS) applications, with each tier running on a separate set of VMs. However, an N-tier application doesn't need to be pure IaaS. Often, it's advantageous to use managed services for some parts of the architecture, particularly caching, messaging, and data storage.

Consider an N-tier architecture for:

Simple web applications.
Migrating an on-premises application to Azure with minimal refactoring.
Unified development of on-premises and cloud applications.
N-tier architectures are very common in traditional on-premises applications, so it's a natural fit for migrating existing workloads to Azure.

Benefits
Portability between cloud and on-premises, and between cloud platforms.
Less learning curve for most developers.
Natural evolution from the traditional application model.
Open to heterogeneous environment (Windows/Linux)
