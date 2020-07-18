using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace Discord_bot_for_InVecta
{
    class client
    {

        public class Commands : ModuleBase<SocketCommandContext>
        {

            [Command("news")]
            public async Task news([Remainder] string news)
            {
                var EmbedBuilder = new EmbedBuilder()
                            .WithDescription($"{news}")
                            .WithFooter(footer =>
                            {
                                footer
                                .WithText("NEWS")
                                .WithIconUrl("https://media.discordapp.net/attachments/728384401867800597/732210009089376336/IMG_20200713_150610.jpg?width=475&height=475");
                            });
                Embed embed = EmbedBuilder.Build();
                await ReplyAsync(embed: embed);

                ITextChannel logChannel = Context.Client.GetChannel(642698444431032330) as ITextChannel;
                var EmbedBuilderLog = new EmbedBuilder()
                    .WithDescription($"ff")
                    .WithFooter(footer =>
                    {
                        footer
                        .WithText("NEWS")
                        .WithIconUrl("https://media.discordapp.net/attachments/728384401867800597/732210009089376336/IMG_20200713_150610.jpg?width=475&height=475");
                    });
                Embed embedLog = EmbedBuilderLog.Build();
            }

            [Command("Навигация")]
            public async Task navig([Remainder] string navig)
            {
                var EmbedBuilder = new EmbedBuilder()
            .WithDescription($"{navig}")
            .WithFooter(footer =>
            {
                footer
                .WithText("НАВИГАЦИЯ")
                .WithIconUrl("https://media.discordapp.net/attachments/728384401867800597/732210009089376336/IMG_20200713_150610.jpg?width=475&height=475");
            });
                Embed embed = EmbedBuilder.Build();
                await ReplyAsync(embed: embed);

                ITextChannel logChannel = Context.Client.GetChannel(642698444431032330) as ITextChannel;
                var EmbedBuilderLog = new EmbedBuilder()
                    .WithDescription($"НАВИГАЦИЯ")
                    .WithFooter(footer =>
                    {
                        footer
                        .WithText("НАВИГАЦИЯ")
                        .WithIconUrl("https://media.discordapp.net/attachments/728384401867800597/732210009089376336/IMG_20200713_150610.jpg?width=475&height=475");
                    });
                Embed embedLog = EmbedBuilderLog.Build();
            }

            [Command("Своя анкета")]
            public async Task my_ank([Remainder] string my_ank)
            {
                var EmbedBuilder = new EmbedBuilder()
            .WithDescription($"{my_ank}")
            .WithFooter(footer =>
            {
                footer
                .WithText("АНКЕТА")
                .WithIconUrl("https://media.discordapp.net/attachments/728384401867800597/732210009089376336/IMG_20200713_150610.jpg?width=475&height=475");
            });
                Embed embed = EmbedBuilder.Build();
                await ReplyAsync(embed: embed);

                ITextChannel logChannel = Context.Client.GetChannel(642698444431032330) as ITextChannel;
                var EmbedBuilderLog = new EmbedBuilder()
                    .WithDescription($"АНКЕТА")
                    .WithFooter(footer =>
                    {
                        footer
                        .WithText("АНКЕТА")
                        .WithIconUrl("https://media.discordapp.net/attachments/728384401867800597/732210009089376336/IMG_20200713_150610.jpg?width=475&height=475");
                    });
                Embed embedLog = EmbedBuilderLog.Build();
            }
            [Command("анкета")]
            public async Task ank()
            {
                var EmbedBuilder = new EmbedBuilder()
                            .WithDescription("@everyone \n\n\n> 1. Скрины против т4-т3 кланов (если нету то статистику)\n> 2. Адекватность \n> З. Актив\n> 4. Ник (как читается, русскими буквами)\n> 5. Девайс?\n> 6. Иметь наушники-микро \n> 7. Не быть токс, чсв\n> 8. Пинг ру/еу\n> 9. Причины лива из прошлых кланов")
                            .WithFooter(footer =>
                            {
                                footer
                                .WithText("АНКЕТА")
                                .WithIconUrl("https://media.discordapp.net/attachments/728384401867800597/732210009089376336/IMG_20200713_150610.jpg?width=475&height=475");
                            });
                Embed embed = EmbedBuilder.Build();
                await ReplyAsync(embed: embed);

                ITextChannel logChannel = Context.Client.GetChannel(642698444431032330) as ITextChannel;
                var EmbedBuilderLog = new EmbedBuilder()
                    .WithDescription($"АНКЕТА")
                    .WithFooter(footer =>
                    {
                        footer
                        .WithText("АНКЕТА")
                        .WithIconUrl("https://media.discordapp.net/attachments/728384401867800597/732210009089376336/IMG_20200713_150610.jpg?width=475&height=475");
                    });
                Embed embedLog = EmbedBuilderLog.Build();
            }

            [Command("rules")]
            public async Task rules([Remainder] string rules)
            {
                var EmbedBuilder = new EmbedBuilder()
                            .WithDescription($"{rules}")
                            .WithFooter(footer =>
                            {
                                footer
                                .WithText("RULES")
                                .WithIconUrl("https://media.discordapp.net/attachments/728384401867800597/732210009089376336/IMG_20200713_150610.jpg?width=475&height=475");
                            });
                Embed embed = EmbedBuilder.Build();
                await ReplyAsync(embed: embed);

                ITextChannel logChannel = Context.Client.GetChannel(642698444431032330) as ITextChannel;
                var EmbedBuilderLog = new EmbedBuilder()
                    .WithDescription($"RULES")
                    .WithFooter(footer =>
                    {
                        footer
                        .WithText("rules")
                        .WithIconUrl("https://media.discordapp.net/attachments/728384401867800597/732210009089376336/IMG_20200713_150610.jpg?width=475&height=475");
                    });
                Embed embedLog = EmbedBuilderLog.Build();
            }

         


          

            /**    [Command("ban")]
                [RequireUserPermission(GuildPermission.BanMembers, ErrorMessage = "You don't have the permission ``ban_member``!")]
                public async Task BanMember(IGuildUser user = null, [Remainder] string reason = null)
                {
                    if (user == null)
                    {
                        await ReplyAsync("Please specify a user!");
                        return;
                    }
                    if (reason == null) reason = "Not specified";

                    await Context.Guild.AddBanAsync(user, 1, reason);

                    var EmbedBuilder = new EmbedBuilder()
                        .WithDescription($":white_check_mark: {user.Mention} was banned\n**Reason** {reason}")
                        .WithFooter(footer =>
                        {
                            footer
                            .WithText("User Ban Log")
                            .WithIconUrl("https://i.imgur.com/6Bi17B3.png");
                        });
                    Embed embed = EmbedBuilder.Build();
                    await ReplyAsync(embed: embed);

                    ITextChannel logChannel = Context.Client.GetChannel(642698444431032330) as ITextChannel;
                    var EmbedBuilderLog = new EmbedBuilder()
                        .WithDescription($"{user.Mention} was banned\n**Reason** {reason}\n**Moderator** {Context.User.Mention}")
                        .WithFooter(footer =>
                        {
                            footer
                            .WithText("User Ban Log")
                            .WithIconUrl("https://i.imgur.com/6Bi17B3.png");
                        });
                    Embed embedLog = EmbedBuilderLog.Build();
                    Console.WriteLine("Участник забанен");
                    await logChannel.SendMessageAsync(embed: embedLog);

                }
        **/
        }
    }
}
