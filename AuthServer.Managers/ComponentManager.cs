using Framework.Database.Auth.Entities;
using Framework.Misc;
using System;
using System.Collections.Generic;

namespace AuthServer.Managers
{
	internal class ComponentManager : Singleton<ComponentManager>
	{
		public readonly List<Component> ComponentList;

		private ComponentManager()
		{
			while (true)
			{
				IL_56:
				uint arg_3A_0 = 2201085066u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3A_0 ^ 3426134644u)) % 4u)
					{
					case 0u:
						goto IL_56;
					case 2u:
						this.ComponentList = new List<Component>();
						arg_3A_0 = (num * 1962598982u ^ 3047614479u);
						continue;
					case 3u:
						this.UpdateComponents();
						arg_3A_0 = (num * 793442269u ^ 2768301186u);
						continue;
					}
					return;
				}
			}
		}

		private void UpdateComponents()
		{
			this.ComponentList.Add(new Component
			{
				Program = Module.smethod_34<string>(2034649298u),
				Platform = Module.smethod_34<string>(1166338410u),
				Build = 37165
			});
			this.ComponentList.Add(new Component
			{
				Program = Module.smethod_37<string>(1549176181u),
				Platform = Module.smethod_36<string>(3397942751u),
				Build = 37165
			});
			this.ComponentList.Add(new Component
			{
				Program = Module.smethod_36<string>(810534065u),
				Platform = Module.smethod_35<string>(1507037613u),
				Build = 37165
			});
			while (true)
			{
				IL_348:
				uint arg_320_0 = 1460973133u;
				while (true)
				{
					uint num;
					switch ((num = (arg_320_0 ^ 2036024312u)) % 7u)
					{
					case 0u:
						this.ComponentList.Add(new Component
						{
							Program = Module.smethod_36<string>(4080966195u),
							Platform = Module.smethod_37<string>(2367262383u),
							Build = 20740
						});
						arg_320_0 = (num * 424936345u ^ 514104224u);
						continue;
					case 2u:
						this.ComponentList.Add(new Component
						{
							Program = Module.smethod_37<string>(2279612395u),
							Platform = Module.smethod_36<string>(3397942751u),
							Build = 20740
						});
						arg_320_0 = (num * 2746381852u ^ 4005667328u);
						continue;
					case 3u:
						this.ComponentList.Add(new Component
						{
							Program = Module.smethod_33<string>(3055332232u),
							Platform = Module.smethod_33<string>(3272632922u),
							Build = 20365
						});
						this.ComponentList.Add(new Component
						{
							Program = Module.smethod_36<string>(4080966195u),
							Platform = Module.smethod_35<string>(975436991u),
							Build = 20740
						});
						this.ComponentList.Add(new Component
						{
							Program = Module.smethod_36<string>(4080966195u),
							Platform = Module.smethod_37<string>(1636826169u),
							Build = 20740
						});
						arg_320_0 = (num * 1376767305u ^ 642481958u);
						continue;
					case 4u:
						this.ComponentList.Add(new Component
						{
							Program = Module.smethod_36<string>(4080966195u),
							Platform = Module.smethod_33<string>(4141835682u),
							Build = 20740
						});
						arg_320_0 = (num * 2675135237u ^ 3124647892u);
						continue;
					case 5u:
						goto IL_348;
					case 6u:
						this.ComponentList.Add(new Component
						{
							Program = Module.smethod_37<string>(2191962407u),
							Platform = Module.smethod_37<string>(2892985485u),
							Build = 20740
						});
						this.ComponentList.Add(new Component
						{
							Program = Module.smethod_36<string>(4080966195u),
							Platform = Module.smethod_37<string>(731089979u),
							Build = 20740
						});
						this.ComponentList.Add(new Component
						{
							Program = Module.smethod_33<string>(933371836u),
							Platform = Module.smethod_36<string>(2605452825u),
							Build = 20740
						});
						arg_320_0 = (num * 1684039673u ^ 1973202353u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			this.ComponentList.Add(new Component
			{
				Program = Module.smethod_36<string>(1835069231u),
				Platform = Module.smethod_34<string>(2315859134u),
				Build = 20740
			});
		}
	}
}
