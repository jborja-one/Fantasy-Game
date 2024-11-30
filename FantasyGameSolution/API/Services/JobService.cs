﻿using System;using System.Reflection;using API.DTOs;using Core.Jobs;using Core.Models;namespace API.Services{    //public class JobService    //{    //    private readonly Job _job;    //    public JobService(Job job)    //    {    //        _job = job;    //    }    //    public List<JobDto> GetAllJobs()    //    {    //        return new List<JobDto>    //        {    //            new JobDto    //            {    //                JobId = _job.JobId,    //                Name = _job.Name,    //                Description = "On the northernmost edge of Abalathia's Spine exists a mountain tribe renowned for producing fearsome mercenaries. Wielding greataxes and known as warriors, these men and women learn to harness their inner-beasts and translate that power to unbridled savagery on the battlefield.",    //                Actions = new List<ActionDto>    //                {    //                    new ActionDto    //                    {    //                        Name = "Heavy Swing",    //                        Description = "Delivers a physical attack with a potency of 15",    //                        Cooldown = 2,    //                        Potency = 15,    //                        RequiredLevel = 1    //                    }    //                },    //                Abilities = new List<AbilityDto>    //                {    //                    new AbilityDto    //                    {    //                        Name = "Rampart",    //                        Description = "Reduces damage taken by 20%",    //                        Cooldown = 90,    //                        Effect = "Reduces damage taken by 20%",    //                        RequiredLevel = 8,    //                    }    //                }    //            }    //        };    //    }    //    public JobDto? GetJobDetails(string jobName)    //    {    //        return GetAllJobs().FirstOrDefault(job => job.Name.Equals(jobName, StringComparison.OrdinalIgnoreCase));    //    }    //}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 public class JobService    {        private readonly List<Job> _jobs;        public JobService()        {            _jobs = LoadAllJobs();        }        private List<Job> LoadAllJobs()        {            var jobType = typeof(Job);            var jobTypes = Assembly.GetAssembly(jobType)?.GetTypes()                .Where(t => t.IsSubclassOf(jobType) && !t.IsAbstract)                .ToList();            var jobs = jobTypes?.Select(t => (Job)Activator.CreateInstance(t)).ToList() ?? new List<Job>();            foreach (var job in jobs)            {                job.Initialize();            }            return jobs;        }        public IEnumerable<Job> GetAllJobs()        {            return _jobs;        }        public Job? GetJobByName(string jobName)        {            return _jobs.FirstOrDefault(j => j.Name.Equals(jobName, StringComparison.OrdinalIgnoreCase));        }    }}