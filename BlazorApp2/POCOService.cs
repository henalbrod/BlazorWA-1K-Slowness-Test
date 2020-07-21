using BlazorApp2.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Ryzen 5 3400G, 16Gb RAM 3200mhz, SSD NVMe
/// </summary>
namespace BlazorApp2
{
    public class POCOService
    {

        public async IAsyncEnumerable<POCO> RangeAsync(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var newItem = await GetItemAsync(i);
                yield return newItem;
            }
        }

        private async Task<POCO> GetItemAsync(int index) {

            return await Task.Run(()=> new POCO
            {
                Index = index,
                // 12 properties out of 30 are from serializing a value
                Prop1 = GetSerializedValue(true),
                Prop2 = GetSerializedValue(true),
                Prop3 = GetSerializedValue(true),
                Prop4 = GetSerializedValue(true),
                Prop5 = GetSerializedValue(true),
                Prop6 = GetSerializedValue(true),
                Prop7 = GetSerializedValue(true),
                Prop8 = GetSerializedValue(true),
                Prop9 = GetSerializedValue(true),
                Prop10 = GetSerializedValue(true),
                Prop11 = GetSerializedValue(true),
                Prop12 = GetSerializedValue(true),
                Prop13 = GetSerializedValue(),
                Prop14 = GetSerializedValue(),
                Prop15 = GetSerializedValue(),
                Prop16 = GetSerializedValue(),
                Prop17 = GetSerializedValue(),
                Prop18 = GetSerializedValue(),
                Prop19 = GetSerializedValue(),
                Prop20 = GetSerializedValue(),
                Prop21 = GetSerializedValue(),
                Prop22 = GetSerializedValue(),
                Prop23 = GetSerializedValue(),
                Prop24 = GetSerializedValue(),
                Prop25 = GetSerializedValue(),
                Prop26 = GetSerializedValue(),
                Prop27 = GetSerializedValue(),
                Prop28 = GetSerializedValue(),
                Prop29 = GetSerializedValue(),
                Prop30 = GetSerializedValue(),
            });

        }

        private string GetSerializedValue(bool serialize = false) {
            return serialize ? System.Text.Json.JsonSerializer.Serialize(Guid.NewGuid()) : "Plain Value";
        }

    }
}
