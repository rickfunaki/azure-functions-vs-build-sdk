﻿using System.Runtime.CompilerServices;

#if RELESE_BUILD
[assembly: InternalsVisibleTo("Microsoft.NET.Sdk.Functions.Test, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b5fc90e7027f67871e773a8fde8938c81dd402ba65b9201d60593e96c492651e889cc13f1415ebb53fac1131ae0bd333c5ee6021672d9718ea31a8aebd0da0072f25d87dba6fc90ffd598ed4da35e44c398c454307e8e33b8426143daec9f596836f97c8f74750e5975c64e2189f45def46b2a2b1247adc3652bf5c308055da9")]
[assembly: InternalsVisibleTo("Microsoft.NET.Sdk.Functions.Test.V1, PublicKey=0024000004800000940000000602000000240000525341310004000001000100d992c94d1071c5467ec320753f4a3cd4e3968a8d16944c09b12baeddee07f0c02c87552de2fe4bf62c35e95449f9a2b3a3930701029981b0dee4dbea68321a19a96289c05a4be24713e1447dd803be701582e6fe6ad53190f51c7200128eb663a81737f32cde60d114a1387e525618e16968c42efa9b3939e6e19806ca230ed1")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2, PublicKey=0024000004800000940000000602000000240000525341310004000001000100c547cac37abd99c8db225ef2f6c8a3602f3b3606cc9891605d02baa56104f4cfc0734aa39b93bf7852f7d9266654753cc297e7d2edfe0bac1cdcf9f717241550e0a7b191195b7667bb4f64bcb8e2121380fd1d9d46ad2d92d2d15605093924cceaf74c4861eff62abf69b9291ed0a340e113be11e6a7d3113e92484cf7045cc7")]
#else
[assembly: InternalsVisibleTo("Microsoft.NET.Sdk.Functions.Test")]
[assembly: InternalsVisibleTo("Microsoft.NET.Sdk.Functions.Test.V1")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
#endif